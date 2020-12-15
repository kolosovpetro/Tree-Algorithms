namespace Trees.Heap.Implementations
{
    public class MinHeap : MaxHeap
    {
        public override void CalculateUp(int elementIndex)
        {
            if (elementIndex == 0) return;
            var parentIndex = ParentIndex(elementIndex);
            if (HeapBase[parentIndex] < HeapBase[elementIndex]) return;
            Swap(elementIndex, parentIndex);
            CalculateUp(parentIndex);
        }

        public override void CalculateDown(int elementIndex)
        {
            while (HasLeft(elementIndex))
            {
                var lesserIndex = LeftChildIndex(elementIndex);

                if (HasRight(elementIndex) && GetRightChild(elementIndex) < GetLeftChild(elementIndex))
                    lesserIndex = RightChildIndex(elementIndex);

                if (HeapBase[lesserIndex] > HeapBase[elementIndex])
                    break;

                Swap(lesserIndex, elementIndex);
                elementIndex = lesserIndex;
            }
        }
    }
}