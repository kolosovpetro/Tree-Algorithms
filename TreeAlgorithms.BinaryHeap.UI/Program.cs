using System;
using TreeAlgorithms.BinaryHeap.Implementations;
using TreeAlgorithms.BinaryHeap.Interfaces;

namespace TreeAlgorithms.BinaryHeap.UI
{
    public static class Program
    {
        private static void Main()
        {
            IBinaryHeap maxHeap = new MaxHeap();
            maxHeap.PushRange(5, 7, 12, 6, 8, 9, 1, 3, 5, 21, 42, 15, 32);
            Console.WriteLine("Max heap: ");
            maxHeap.PrintHeap();

            Console.WriteLine();
            Console.WriteLine("Heap sort Max: ");
            
            while (!maxHeap.IsEmpty)
            {
                Console.Write(maxHeap.Pop() + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Min heap: ");
            IBinaryHeap minHeap = new MinHeap();
            minHeap.PushRange(5, 7, 12, 6, 8, 9, 1, 3, 5, 21, 42, 15, 32);
            minHeap.PrintHeap();
            Console.WriteLine();
            Console.WriteLine("Heap sort min: ");

            while (!minHeap.IsEmpty)
            {
                Console.Write(minHeap.Pop() + " ");
            }
        }
    }
}