namespace MB17.PriorityQueue.MaxHeap
{
    public class MaxHeap
    {
        private int[] Heap { get; set; }
        private int Size { get; set; }
        private int Capacity { get; set; }

        public MaxHeap(int capacity)
        {
            this.Capacity = capacity;
            Heap = new int[capacity];
            Size = 0;
        }

        #region Iterativ Enqueue
        public void Enqueue(int value)
        {
            if (Size < Capacity)
            {
                // Implement Enqueue.....



            }
        }

        private int GetParentIndex(int index)
        {
            var parentIndex = (index - 1) / 2;
            return parentIndex;
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            int temp = Heap[currentIndex];
            Heap[currentIndex] = Heap[parentIndex];
            Heap[parentIndex] = temp;
        }
        #endregion

        #region Recursive Enqueue
        public void EnqueueRecursive(int value)
        {
            if (Size < Capacity)
            {
                // Implement Enqueue.....

            }
        }

        private void BubbleUp(int index)
        {

            // hier soll das Element "hoch gebubblet" werden" (Rekursiv)
        }

        #endregion

        #region Dequeue
        public int Dequeue()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }
            var root = Heap[0];

            // Implement Dequeue.....



            return root;
        }



        #endregion

        #region Recursive Dequeue
        public int DequeueRecursive()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            int root = Heap[0];
            // Implement Dequeue.....


            return root;
        }

        private void BubbleDown(int index)
        {
            // hier soll das Element "runter gebubblet" werden" (Rekursiv)
        }

        private int GetLeftChildIndex(int index)
        {
            return 2 * index + 1;
        }

        private int GetRightChildIndex(int index)
        {
            return 2 * index + 2;
        }

        #endregion


        public void PrintHeap()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write(Heap[i] + " ");
            }
            Console.WriteLine();
        }
    }

}

