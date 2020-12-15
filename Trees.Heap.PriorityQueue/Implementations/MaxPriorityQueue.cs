using System;
using System.Collections.Generic;
using System.Linq;
using PriorityQueue.Interfaces;

namespace Trees.Heap.PriorityQueue.Implementations
{
    public class MaxPriorityQueue<T> : IPriorityQueue<T>
    {
        protected readonly List<IPriorityQueueNode<T>> QueueNodes = new List<IPriorityQueueNode<T>>();

        public int Count => QueueNodes.Count;
        public bool IsEmpty => !QueueNodes.Any();
        public int ParentIndex(int childIndex) => (childIndex - 1) / 2;
        public int LeftChildIndex(int parentIndex) => 2 * parentIndex + 1;
        public int RightChildIndex(int parentIndex) => 2 * parentIndex + 2;
        public bool HasLeft(int parentIndex) => LeftChildIndex(parentIndex) < Count;
        public bool HasRight(int parentIndex) => RightChildIndex(parentIndex) < Count;
        public IPriorityQueueNode<T> GetParent(int childIndex) => QueueNodes[ParentIndex(childIndex)];
        public IPriorityQueueNode<T> GetLeftChild(int parentIndex) => QueueNodes[LeftChildIndex(parentIndex)];
        public IPriorityQueueNode<T> GetRightChild(int parentIndex) => QueueNodes[RightChildIndex(parentIndex)];
        public IPriorityQueueNode<T> Peek() => QueueNodes.First();

        public IPriorityQueueNode<T> Dequeue()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Queue is empty.");

            var result = QueueNodes.First();
            QueueNodes[0] = QueueNodes.Last();
            QueueNodes.RemoveAt(Count - 1);
            CalculateDown(0);
            return result;
        }

        public void Enqueue(T data, int priority)
        {
            QueueNodes.Add(new PriorityQueueNode<T>(data, priority));
            CalculateUp(Count - 1);
        }

        public virtual void CalculateUp(int elementIndex)
        {
            if (elementIndex == 0) return;
            var parentIndex = ParentIndex(elementIndex);
            if (QueueNodes[parentIndex].Priority > QueueNodes[elementIndex].Priority) return;
            Swap(elementIndex, parentIndex);
            CalculateUp(parentIndex);
        }

        public virtual void CalculateDown(int elementIndex)
        {
            while (HasLeft(elementIndex))
            {
                var biggerIndex = LeftChildIndex(elementIndex);

                if (HasRight(elementIndex)
                    && GetRightChild(elementIndex).Priority > GetLeftChild(elementIndex).Priority)
                {
                    biggerIndex = RightChildIndex(elementIndex);
                }

                if (QueueNodes[biggerIndex].Priority < QueueNodes[elementIndex].Priority)
                    break;

                Swap(biggerIndex, elementIndex);
                elementIndex = biggerIndex;
            }
        }

        public void PrintQueue()
        {
            while (!IsEmpty) Console.WriteLine(Dequeue());
        }

        protected void Swap(int elementIndex, int parentIndex)
        {
            var temp = QueueNodes[parentIndex];
            QueueNodes[parentIndex] = QueueNodes[elementIndex];
            QueueNodes[elementIndex] = temp;
        }
    }
}