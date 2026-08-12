using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace MB15.SortComparison
{
    public abstract class SortAlgorithm
    {
        private SortingList arrayToSort;
        private Graphics g;
        private Bitmap bmpsave;
        private PictureBox pnlSamples;

        private int operationsPerFrame; // operations per frame
        private int frameMS; // time between frames (aim for 40 ms = 25 fps)

        private int operationCount;

        private readonly HashSet<int> highlightedIndexes = new HashSet<int>(); // highlight all of these indexes in the frame

        private DateTime nextFrameTime;
        private int originalPanelHeight;

        public abstract string Name { get; }

        // WICHTIG: Damit die Visualisierung funktioniert, muss eine "InPlace-Sortierung" durchgeführt werden.
        //          D.h. arrayToSort muss sortiert werden - es darf keine neue Liste erzeugt werden.
        //          Deswegen hat die Methode auch keinen Rückgabewert.
        public abstract void Sort(IList<int> arrayToSort);

        public void Setup(SortingList list, PictureBox pic, int s, string outFile)
        {
            list.OnHighlighting += (source, args) => {
                this.HighlightIndex(args.Index);
            };
            arrayToSort = list;
            pnlSamples = pic;

            operationCount = 0;
            operationsPerFrame = s;
            frameMS = 1000; // so now operationsPerFrame is operations per second

            // reduce the frame wait for better visuals (increased frame rate)
            while (frameMS >= 40 && operationsPerFrame > 1)
            {
                operationsPerFrame = operationsPerFrame / 2;
                frameMS = frameMS / 2;
            }

            bmpsave = new Bitmap(pnlSamples.Width, pnlSamples.Height);
            g = Graphics.FromImage(bmpsave);
            originalPanelHeight = pnlSamples.Height;
            pnlSamples.Image = bmpsave;
            nextFrameTime = DateTime.UtcNow;

            checkForFrame();
        }

        protected void HighlightIndex(int index)
        {
            this.highlightedIndexes.Add(index);

            operationCount++;
            checkForFrame();

        }

        private void checkForFrame()
        {
            lock (this.sync)
            {
                if (operationCount >= operationsPerFrame || nextFrameTime <= DateTime.UtcNow)
                {
                    // time to draw a new frame and wait
                    DrawSamples();
                    RefreshPanel(pnlSamples);

                    // prepare for next frame
                    highlightedIndexes.Clear();
                    operationCount -= operationsPerFrame; // if there were more operations than needed, don't just forget those

                    if (DateTime.UtcNow < nextFrameTime)
                    {
                        Thread.Sleep((int)((nextFrameTime - DateTime.UtcNow).TotalMilliseconds));
                    }

                    nextFrameTime = nextFrameTime.AddMilliseconds(frameMS);
                }
            }
        }

        public void finishDrawing()
        {
            if (highlightedIndexes.Count > 0)
            {
                // put one last frame in before the end
                nextFrameTime = DateTime.UtcNow;
                checkForFrame();
            }

            // draw the last frame
            nextFrameTime = DateTime.UtcNow;
            checkForFrame();
        }




        private void RefreshPanel(Control pnlSort)
        {
            if (pnlSort.InvokeRequired)
            {
                pnlSort.Invoke((MethodInvoker)delegate { this.RefreshPanel(pnlSort); });
            }
            else
            {
                pnlSort.Refresh();
            }
        }

        private object sync = new object();
        public void DrawSamples()
        {
            lock (this.sync)
            {
                using (this.arrayToSort.BlockHighlighting())
                {
                    // sichere Abfrage der Panel-Größe (UI-Thread)
                    int panelWidth = pnlSamples.Width;
                    int panelHeight = pnlSamples.Height;
                    if (pnlSamples.InvokeRequired)
                    {
                        pnlSamples.Invoke(new Action(() => { panelWidth = pnlSamples.Width; panelHeight = pnlSamples.Height; }));
                    }

                    // might need to grow or shrink if size is different from original (can't change array!)
                    double multiplyHeight = 1;
                    if (panelHeight != originalPanelHeight)
                    {
                        multiplyHeight = (panelHeight) / (double)(originalPanelHeight);
                    }

                    // Erzeuge lokales Bitmap und zeichne darauf (Thread-sicher)
                    var drawWidth = Math.Max(1, panelWidth);
                    var drawHeight = Math.Max(1, panelHeight);
                    var bmp = new Bitmap(drawWidth, drawHeight);
                    using (var gg = Graphics.FromImage(bmp))
                    using (var pen = new Pen(Color.Black))
                    using (var b = new SolidBrush(Color.Black))
                    using (var redPen = new Pen(Color.Red))
                    using (var redBrush = new SolidBrush(Color.Red))
                    {
                        gg.Clear(Color.White);

                        // draw a nice width based on number of elements
                        var w = (drawWidth / arrayToSort.Count) - 1;

                        for (var i = 0; i < this.arrayToSort.Count; i++)
                        {
                            var x = (int)(((double)drawWidth / arrayToSort.Count) * i);

                            var itemHeight = (int)Math.Round(Convert.ToDouble(arrayToSort[i]) * multiplyHeight);

                            if (highlightedIndexes.Contains(i))
                            {
                                // draw highlighed versions
                                if (w <= 1)
                                {
                                    gg.DrawLine(redPen, new Point(x, drawHeight), new Point(x, (drawHeight - itemHeight)));
                                }
                                else
                                {
                                    gg.FillRectangle(redBrush, x, drawHeight - itemHeight, w, drawHeight);
                                }
                            }
                            else
                            {
                                // draw normal versions
                                if (w <= 1)
                                {
                                    gg.DrawLine(pen, new Point(x, drawHeight), new Point(x, (drawHeight - itemHeight)));
                                }
                                else
                                {
                                    gg.FillRectangle(b, x, drawHeight - itemHeight, w, drawHeight);
                                }
                            }
                        }
                    }

                    // Setze das fertige Bitmap auf dem UI-Thread (tausche und dispose altes Bild)
                    if (pnlSamples.InvokeRequired)
                    {
                        pnlSamples.Invoke(new Action(() =>
                        {
                            var old = pnlSamples.Image;
                            pnlSamples.Image = bmp;
                            old?.Dispose();
                        }));
                    }
                    else
                    {
                        var old = pnlSamples.Image;
                        pnlSamples.Image = bmp;
                        old?.Dispose();
                    }
                }
            }
        }
    }
}