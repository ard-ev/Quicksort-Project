using MB17.PriorityQueue.MaxHeap;

class Program
{
    static void Main(string[] args)
    {
        MaxHeap maxHeap = new MaxHeap(10);
        maxHeap.Enqueue(10);
        maxHeap.Enqueue(20);
        maxHeap.Enqueue(26);
        maxHeap.Enqueue(30);
        maxHeap.Enqueue(25);

        maxHeap.PrintHeap();

        maxHeap.Dequeue();
        maxHeap.PrintHeap();

        maxHeap.Dequeue();
        maxHeap.PrintHeap();

        MaxHeap maxHeap2 = new MaxHeap(10);
        maxHeap2.EnqueueRecursive(10);
        maxHeap2.EnqueueRecursive(20);
        maxHeap2.EnqueueRecursive(15);
        maxHeap2.EnqueueRecursive(30);
        maxHeap2.EnqueueRecursive(25);

        maxHeap2.PrintHeap();


    }
}