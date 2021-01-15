using System.Linq;

namespace Trees.Heap.Implementations
{
    public class FloydMaxHeap : MaxHeap
    {
        public override int Pop()
        {
            var result = HeapBase[0];
            HeapBase[0] = HeapBase.Last();
            HeapBase.RemoveAt(Count - 1);
            FloydRestoreHeapProperty();
            return result;
        }

        private void FloydRestoreHeapProperty()
        {
            for (var i = Count / 2; i >= 0; i--)
                CalculateDown(i);
        }
        
        public static FloydMaxHeap BuildMaxHeap(params int[] array)
        {
            var heap = new FloydMaxHeap();

            foreach (var number in array)
                heap.Push(number);

            return heap;
        }
    }
}