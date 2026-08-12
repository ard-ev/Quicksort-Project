using System.Collections.Generic;
using MB15.SortComparison;

namespace MB11.SortComparison.SortingAlgorithms.Lsg
{
    public class BubbleSort : SortAlgorithm
    {
        public override string Name => "Bubblesort";
        public override void Sort(IList<int> arrayToSort)
        {
            var swapMade = true;
            var n = arrayToSort.Count - 1;
            for (var i = 0; i < n && swapMade; i++)
            {
                swapMade = false;

                for (var j = n; j > i; j--)
                {
                    var num1 = arrayToSort[j - 1];
                    var num2 = arrayToSort[j];
                    if (num1 > num2)
                    {
                        SwapItems(arrayToSort, j - 1, j);
                        swapMade = true;
                    }
                }
            }
        }

        private void SwapItems(IList<int> arrayToSort, int index1, int index2)
        {
            var temp = arrayToSort[index1];
            arrayToSort[index1] = arrayToSort[index2];
            arrayToSort[index2] = temp;
        }
    }
}
