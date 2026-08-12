using System.Drawing;
using System.Windows.Forms;

namespace MB15.SortComparison
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboAlg1 = new ComboBox();
            cboAlg2 = new ComboBox();
            cmdSort = new Button();
            pnlSort1 = new PictureBox();
            pnlSort2 = new PictureBox();
            tbSamples = new TrackBar();
            lblSamples = new Label();
            label1 = new Label();
            tbSpeed = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ddTypeOfData = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pnlSort1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlSort2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSamples).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            SuspendLayout();
            // 
            // cboAlg1
            // 
            cboAlg1.Anchor = AnchorStyles.Bottom;
            cboAlg1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlg1.FormattingEnabled = true;
            cboAlg1.Items.AddRange(new object[] { "", "BiDirectional Bubble Sort", "Bubble Sort", "Comb Sort", "Counting Sort", "Cycle Sort", "Gnome Sort", "Heap Sort", "Insertion Sort", "Merge Sort (In Place)", "Merge Sort (Double Storage)", "Odd-Even Sort", "Pigeonhole Sort", "Quicksort", "Quicksort with Insertion Sort", "Radix Sort", "Selection Sort", "Shell Sort", "Smoothsort", "Timsort" });
            cboAlg1.Location = new Point(112, 516);
            cboAlg1.Margin = new Padding(5, 4, 5, 4);
            cboAlg1.Name = "cboAlg1";
            cboAlg1.Size = new Size(298, 28);
            cboAlg1.TabIndex = 2;
            // 
            // cboAlg2
            // 
            cboAlg2.Anchor = AnchorStyles.Bottom;
            cboAlg2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlg2.FormattingEnabled = true;
            cboAlg2.Items.AddRange(new object[] { "", "BiDirectional Bubble Sort", "Bubble Sort", "Comb Sort", "Counting Sort", "Cycle Sort", "Gnome Sort", "Heap Sort", "Insertion Sort", "Merge Sort (In Place)", "Merge Sort (Double Storage)", "Odd-Even Sort", "Pigeonhole Sort", "Quicksort", "Quicksort with Insertion Sort", "Radix Sort", "Selection Sort", "Shell Sort", "Smoothsort", "Timsort" });
            cboAlg2.Location = new Point(420, 516);
            cboAlg2.Margin = new Padding(5, 4, 5, 4);
            cboAlg2.Name = "cboAlg2";
            cboAlg2.Size = new Size(298, 28);
            cboAlg2.TabIndex = 3;
            // 
            // cmdSort
            // 
            cmdSort.Anchor = AnchorStyles.Bottom;
            cmdSort.Location = new Point(112, 659);
            cmdSort.Margin = new Padding(5, 4, 5, 4);
            cmdSort.Name = "cmdSort";
            cmdSort.Size = new Size(609, 36);
            cmdSort.TabIndex = 5;
            cmdSort.Text = "Sort";
            cmdSort.UseVisualStyleBackColor = true;
            cmdSort.Click += CmdSort_Click;
            // 
            // pnlSort1
            // 
            pnlSort1.BackColor = Color.White;
            pnlSort1.BorderStyle = BorderStyle.FixedSingle;
            pnlSort1.Location = new Point(19, 19);
            pnlSort1.Margin = new Padding(5, 4, 5, 4);
            pnlSort1.Name = "pnlSort1";
            pnlSort1.Size = new Size(299, 306);
            pnlSort1.TabIndex = 6;
            pnlSort1.TabStop = false;
            // 
            // pnlSort2
            // 
            pnlSort2.Anchor = AnchorStyles.Top;
            pnlSort2.BackColor = Color.White;
            pnlSort2.BorderStyle = BorderStyle.FixedSingle;
            pnlSort2.Location = new Point(420, 19);
            pnlSort2.Margin = new Padding(5, 4, 5, 4);
            pnlSort2.Name = "pnlSort2";
            pnlSort2.Size = new Size(299, 306);
            pnlSort2.TabIndex = 7;
            pnlSort2.TabStop = false;
            // 
            // tbSamples
            // 
            tbSamples.Anchor = AnchorStyles.Bottom;
            tbSamples.LargeChange = 10;
            tbSamples.Location = new Point(298, 572);
            tbSamples.Margin = new Padding(5, 4, 5, 4);
            tbSamples.Maximum = 1000;
            tbSamples.Minimum = 10;
            tbSamples.Name = "tbSamples";
            tbSamples.Size = new Size(180, 45);
            tbSamples.TabIndex = 8;
            tbSamples.TickFrequency = 100;
            tbSamples.Value = 100;
            tbSamples.Scroll += tbSamples_Scroll;
            // 
            // lblSamples
            // 
            lblSamples.Anchor = AnchorStyles.Bottom;
            lblSamples.AutoSize = true;
            lblSamples.Location = new Point(108, 572);
            lblSamples.Margin = new Padding(5, 0, 5, 0);
            lblSamples.Name = "lblSamples";
            lblSamples.Size = new Size(181, 20);
            lblSamples.TabIndex = 9;
            lblSamples.Text = "Number of samples: 100";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(108, 621);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 10;
            label1.Text = "Sorting speed:";
            // 
            // tbSpeed
            // 
            tbSpeed.Anchor = AnchorStyles.Bottom;
            tbSpeed.Location = new Point(298, 621);
            tbSpeed.Margin = new Padding(5, 4, 5, 4);
            tbSpeed.Maximum = 20;
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new Size(180, 45);
            tbSpeed.TabIndex = 11;
            tbSpeed.Value = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(273, 621);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 12;
            label2.Text = "Min";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(471, 621);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 13;
            label3.Text = "Max";
            // 
            // ddTypeOfData
            // 
            ddTypeOfData.Anchor = AnchorStyles.Bottom;
            ddTypeOfData.DropDownStyle = ComboBoxStyle.DropDownList;
            ddTypeOfData.FormattingEnabled = true;
            ddTypeOfData.Items.AddRange(new object[] { "Random", "Reversed", "Sorted", "Nearly Sorted", "Few Unique" });
            ddTypeOfData.Location = new Point(476, 572);
            ddTypeOfData.Margin = new Padding(5, 4, 5, 4);
            ddTypeOfData.Name = "ddTypeOfData";
            ddTypeOfData.Size = new Size(244, 28);
            ddTypeOfData.TabIndex = 34;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 712);
            Controls.Add(cmdSort);
            Controls.Add(ddTypeOfData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbSpeed);
            Controls.Add(label1);
            Controls.Add(lblSamples);
            Controls.Add(tbSamples);
            Controls.Add(pnlSort2);
            Controls.Add(cboAlg2);
            Controls.Add(cboAlg1);
            Controls.Add(pnlSort1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ImeMode = ImeMode.Off;
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(19271, 20472);
            MinimumSize = new Size(853, 751);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sort Comparison";
            FormClosing += frmMain_FormClosing;
            Load += Form1_Load;
            Resize += frmMain_Resize;
            ((System.ComponentModel.ISupportInitialize)pnlSort1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlSort2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSamples).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboAlg1;
        private System.Windows.Forms.ComboBox cboAlg2;
        private System.Windows.Forms.Button cmdSort;
        private System.Windows.Forms.PictureBox pnlSort1;
        private System.Windows.Forms.PictureBox pnlSort2;
        private System.Windows.Forms.TrackBar tbSamples;
        private System.Windows.Forms.Label lblSamples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox ddTypeOfData;
    }
}

