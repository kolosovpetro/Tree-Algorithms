namespace Trees.Heap.Interfaces
{
    public interface IPriorityQueueNode<T>
    {
        T Data { get; }
        int Priority { get; }
    }
}