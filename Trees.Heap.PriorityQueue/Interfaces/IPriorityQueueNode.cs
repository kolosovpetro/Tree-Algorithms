namespace Trees.Heap.PriorityQueue.Interfaces
{
    public interface IPriorityQueueNode<T>
    {
        T Data { get; }
        int Priority { get; }
    }
}