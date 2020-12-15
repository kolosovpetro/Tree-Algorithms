namespace Trees.Heap.Interfaces
{
    public interface IBinaryHeap
    {
        int Count { get; }
        bool IsEmpty { get; }
        int ParentIndex(int childIndex);
        int LeftChildIndex(int parentIndex);
        int RightChildIndex(int parentIndex);
        bool HasLeft(int parentIndex);
        bool HasRight(int parentIndex);
        int GetParent(int childIndex);
        int GetLeftChild(int parentIndex);
        int GetRightChild(int parentIndex);
        void Push(int element);
        void PushRange(params int[] array);
        int Pop();
        int Peek();
        void CalculateUp(int elementIndex);
        void CalculateDown(int elementIndex);
        void PrintHeap();
    }
}