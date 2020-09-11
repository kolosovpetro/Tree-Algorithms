namespace PriorityQueue.Interfaces
{
    public interface IPriorityQueue<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        int ParentIndex(int childIndex);
        int LeftChildIndex(int parentIndex);
        int RightChildIndex(int parentIndex);
        bool HasLeft(int parentIndex);
        bool HasRight(int parentIndex);
        IPriorityQueueNode<T> GetParent(int childIndex);
        IPriorityQueueNode<T> GetLeftChild(int parentIndex);
        IPriorityQueueNode<T> GetRightChild(int parentIndex);
        IPriorityQueueNode<T> Peek();
        IPriorityQueueNode<T> Dequeue();
        void Enqueue(T data, int priority);
        void CalculateUp(int elementIndex);
        void CalculateDown(int elementIndex);
        void PrintQueue();
    }
}