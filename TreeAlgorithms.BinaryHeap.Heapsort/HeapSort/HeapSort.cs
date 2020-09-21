using TreeAlgorithms.BinaryHeap.FloydAlgorithm.Implementation;

namespace TreeAlgorithms.BinaryHeap.Heapsort.HeapSort
{
    public static class HeapSort
    {
        public static int[] HeapSortExecute(params int[] collection)
        {
            var heap = FloydMaxHeap.BuildMaxHeap(collection);
            var arr = new int[collection.Length];

            while (heap.Count > 0)
            {
                var current = heap.Pop();
                arr[heap.Count] = current;
            }

            return arr;
        }
    }
}