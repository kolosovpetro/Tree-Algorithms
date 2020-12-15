using FluentAssertions;
using NUnit.Framework;
using Trees.Heap.Implementations;
using Trees.Heap.Interfaces;

namespace Trees.Tests.BinaryHeapTests.MaxHeapTests
{
    [TestFixture]
    public class MaxHeapGetLeftChildTest
    {
        [Test]
        public void Max_Heap_Get_Left_Child_Test()
        {
            IBinaryHeap heap = new MaxHeap();
            heap.Push(1);
            heap.Push(2);
            heap.Push(3);
            heap.Push(4);
            heap.Push(5);
            heap.Push(6);

            heap.GetLeftChild(0).Should().Be(4);
        }
    }
}