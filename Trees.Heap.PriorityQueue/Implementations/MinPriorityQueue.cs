namespace Trees.Heap.PriorityQueue.Implementations
{
    public class MinPriorityQueue<T> : MaxPriorityQueue<T>
    {
        public override void CalculateUp(int elementIndex)
        {
            if (elementIndex == 0) return;
            var parentIndex = ParentIndex(elementIndex);
            if (QueueNodes[parentIndex].Priority < QueueNodes[elementIndex].Priority) return;
            Swap(elementIndex, parentIndex);
            CalculateUp(parentIndex);
        }

        public override void CalculateDown(int elementIndex)
        {
            while (HasLeft(elementIndex))
            {
                var lesserIndex = LeftChildIndex(elementIndex);

                if (HasRight(elementIndex) &&
                    GetRightChild(elementIndex).Priority < GetLeftChild(elementIndex).Priority)
                    lesserIndex = RightChildIndex(elementIndex);

                if (QueueNodes[lesserIndex].Priority > QueueNodes[elementIndex].Priority)
                    break;

                Swap(lesserIndex, elementIndex);
                elementIndex = lesserIndex;
            }
        }
    }
}