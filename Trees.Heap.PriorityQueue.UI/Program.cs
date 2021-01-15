using System;

namespace Trees.Heap.PriorityQueue.UI
{
    public static class Program
    {
        private static void Main()
        {
            var maxPriorityQueue = new MaxPriorityQueue<string>();
            maxPriorityQueue.Enqueue("Buy bread", 15);
            maxPriorityQueue.Enqueue("Buy milk", 10);
            maxPriorityQueue.Enqueue("Buy chocolate", 17);
            maxPriorityQueue.Enqueue("Go to shop", 30);
            maxPriorityQueue.Enqueue("Go home", 9);

            Console.WriteLine("Max priority queue: ");
            maxPriorityQueue.PrintQueue();
            
            var minPriorityQueue = new MinPriorityQueue<string>();
            minPriorityQueue.Enqueue("Buy bread", 15);
            minPriorityQueue.Enqueue("Buy milk", 10);
            minPriorityQueue.Enqueue("Buy chocolate", 17);
            minPriorityQueue.Enqueue("Go to shop", 30);
            minPriorityQueue.Enqueue("Go home", 9);

            Console.WriteLine("Min priority queue: ");
            minPriorityQueue.PrintQueue();
        }
    }
}