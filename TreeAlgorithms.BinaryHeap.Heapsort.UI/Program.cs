using System;

namespace TreeAlgorithms.BinaryHeap.Heapsort.UI
{
    public static class Program
    {
        public static void Main()
        {
            var sorted = HeapSort.HeapSort.HeapSortExecute(
                1, 6, 4, 9, 1, 0, 25, 3, 87, 43, 23, 12, 11, 10, 74);

            foreach (var number in sorted)
            {
                Console.Write(number + " ");
            }
        }
    }
}