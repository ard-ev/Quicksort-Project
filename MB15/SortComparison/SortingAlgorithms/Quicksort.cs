using System.Collections.Generic;
using MB15.SortComparison;

namespace MB15.SortComparison.SortingAlgorithms
{
    public class QuickSort : SortAlgorithm
    {
        public override string Name => "Quicksort";

        public override void Sort(IList<int> arrayToSort)
        {
            QuickSortAlgorithm(
                arrayToSort,
                0,
                arrayToSort.Count - 1
            );
        }

        private void QuickSortAlgorithm(
            IList<int> arrayToSort,
            int links,
            int rechts)
        {
            if (links < rechts)
            {
                int pivotPosition = Partition(
                    arrayToSort,
                    links,
                    rechts
                );

                // Linken Bereich sortieren
                QuickSortAlgorithm(
                    arrayToSort,
                    links,
                    pivotPosition - 1
                );

                // Rechten Bereich sortieren
                QuickSortAlgorithm(
                    arrayToSort,
                    pivotPosition + 1,
                    rechts
                );
            }
        }

        private int Partition(
            IList<int> arrayToSort,
            int links,
            int rechts)
        {
            // Das letzte Element wird als Pivot gewählt
            int pivot = arrayToSort[rechts];

            // Pivot in der Darstellung hervorheben
            HighlightIndex(rechts);

            int kleinerePosition = links - 1;

            for (int i = links; i < rechts; i++)
            {
                // Verglichenes Element hervorheben
                HighlightIndex(i);

                if (arrayToSort[i] <= pivot)
                {
                    kleinerePosition++;

                    int zwischenspeicher =
                        arrayToSort[kleinerePosition];

                    arrayToSort[kleinerePosition] =
                        arrayToSort[i];

                    arrayToSort[i] = zwischenspeicher;
                }
            }

            // Pivot an seine endgültige Position verschieben
            int temp = arrayToSort[kleinerePosition + 1];

            arrayToSort[kleinerePosition + 1] =
                arrayToSort[rechts];

            arrayToSort[rechts] = temp;

            // Endgültige Pivot-Position hervorheben
            HighlightIndex(kleinerePosition + 1);

            return kleinerePosition + 1;
        }
    }
}