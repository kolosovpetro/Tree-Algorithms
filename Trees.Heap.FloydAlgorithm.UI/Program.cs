using System;
using Trees.Heap.FloydAlgorithm.Implementation;

namespace Trees.Heap.FloydAlgorithm.UI
{
    public static class Program
    {
        private static void Main()
        {
            var arr = new[] {1, 5, 4, 2, 7, 8, 9, 12, 15, 20, 31, 42, 2, 6};
            var floydHeap = FloydMaxHeap.BuildMaxHeap(arr);
            

            while (!floydHeap.IsEmpty)
            {
                Console.Write(floydHeap.Pop() + " ");
            }
        }
    }
}