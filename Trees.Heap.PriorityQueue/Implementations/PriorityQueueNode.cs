using Trees.Heap.PriorityQueue.Interfaces;

namespace Trees.Heap.PriorityQueue.Implementations
{
    public class PriorityQueueNode<T> : IPriorityQueueNode<T>
    {
        public T Data { get; }
        public int Priority { get; }

        public PriorityQueueNode(T data, int priority)
        {
            Data = data;
            Priority = priority;
        }

        public override string ToString() => $"Task: {Data}, Priority: {Priority}";
    }
}