using System.Collections.Generic;

namespace MB15.SortComparison.SortingAlgorithms
{
    public class BubbleSort : SortAlgorithm
    {
        public override string Name => "Bubblesort";

        public override void Sort(IList<int> arrayToSort)
        {
            for (int i = 0; i < arrayToSort.Count - 1; i++)
            {
                for (int j = 0;
                     j < arrayToSort.Count - 1 - i;
                     j++)
                {
                    // Zwei benachbarte Elemente vergleichen
                    HighlightIndex(j);
                    HighlightIndex(j + 1);

                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        SwapItems(arrayToSort, j, j + 1);
                    }
                }
            }
        }

        private void SwapItems(
            IList<int> arrayToSort,
            int index1,
            int index2)
        {
            int zwischenspeicher = arrayToSort[index1];

            arrayToSort[index1] = arrayToSort[index2];
            arrayToSort[index2] = zwischenspeicher;

            // Vertauschte Elemente in der Darstellung markieren
            HighlightIndex(index1);
            HighlightIndex(index2);
        }
    }
}