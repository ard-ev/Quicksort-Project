using System.Collections.Generic;
using MB15.SortComparison;

namespace MB15.SortComparison.SortingAlgorithms
{
    public class QuickSort : SortAlgorithm
    {
        public override string Name => "Quicksort";

        public override void Sort(IList<int> arrayToSort)
        {
            QuickSortAlgorithm(arrayToSort, 0, arrayToSort.Count -1);
        }

        private void QuickSortAlgorithm(IList<int> array, int links, int rechts)
        {
            if (links >= rechts)
                return;

            int i = links;
            int j = rechts;


            int pivot = array[(links + rechts) / 2];

            while (i<= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }


                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }

            if (links < j)
            {
                QuickSortAlgorithm(array, links, j);
            }

            if (i < rechts)
            {
                QuickSortAlgorithm(array, i, rechts);
            }

        }



















    }
}
