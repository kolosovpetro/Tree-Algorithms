﻿using System.Collections.Generic;
using Trees.Heap.Implementations;

namespace Trees.Heap.Sort
{
    public static class HeapSort
    {
        public static IEnumerable<int> HeapSortExecute(params int[] collection)
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