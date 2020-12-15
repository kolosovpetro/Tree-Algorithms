using System;
using System.Collections.Generic;
using System.Linq;
using Trees.Heap.Interfaces;

namespace Trees.Heap.Implementations
{
    public class MaxHeap : IBinaryHeap
    {
        protected List<int> HeapBase { get; }
        public int Count => HeapBase.Count;
        public bool IsEmpty => !HeapBase.Any();

        public MaxHeap() => HeapBase = new List<int>();

        public int ParentIndex(int childIndex) => (childIndex - 1) / 2;
        public int LeftChildIndex(int parentIndex) => 2 * parentIndex + 1;
        public int RightChildIndex(int parentIndex) => 2 * parentIndex + 2;
        public bool HasLeft(int parentIndex) => LeftChildIndex(parentIndex) < Count;
        public bool HasRight(int parentIndex) => RightChildIndex(parentIndex) < Count;
        public int GetParent(int childIndex) => HeapBase[ParentIndex(childIndex)];
        public int GetLeftChild(int parentIndex) => HeapBase[LeftChildIndex(parentIndex)];
        public int GetRightChild(int parentIndex) => HeapBase[RightChildIndex(parentIndex)];

        public void Push(int element)
        {
            HeapBase.Add(element);
            CalculateUp(Count - 1);
        }

        public void PushRange(params int[] array)
        {
            foreach (var number in array) 
                Push(number);
        }

        public virtual int Pop()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Heap is empty.");

            var result = HeapBase[0];
            HeapBase[0] = HeapBase.Last();
            HeapBase.RemoveAt(Count - 1);
            CalculateDown(0);
            return result;
        }

        public int Peek() => HeapBase.First();

        public virtual void CalculateUp(int elementIndex)
        {
            if (elementIndex == 0) return;
            var parentIndex = ParentIndex(elementIndex);
            if (HeapBase[parentIndex] > HeapBase[elementIndex]) return;
            Swap(elementIndex, parentIndex);
            CalculateUp(parentIndex);
        }

        protected void Swap(int elementIndex, int parentIndex)
        {
            var temp = HeapBase[parentIndex];
            HeapBase[parentIndex] = HeapBase[elementIndex];
            HeapBase[elementIndex] = temp;
        }

        public virtual void CalculateDown(int elementIndex)
        {
            while (HasLeft(elementIndex))
            {
                var biggerIndex = LeftChildIndex(elementIndex);

                if (HasRight(elementIndex) && GetRightChild(elementIndex) > GetLeftChild(elementIndex))
                    biggerIndex = RightChildIndex(elementIndex);

                if (HeapBase[biggerIndex] < HeapBase[elementIndex])
                    break;

                Swap(biggerIndex, elementIndex);
                elementIndex = biggerIndex;
            }
        }

        public void PrintHeap() => HeapBase.ForEach(x => Console.Write(x + " "));
    }
}