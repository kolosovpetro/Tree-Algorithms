using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.BinaryHeap.Implementations;
using TreeAlgorithms.BinaryHeap.Interfaces;

namespace TreeAlgorithms.Tests.BinaryHeapTests.MaxHeapTests
{
    [TestFixture]
    public class MaxHeapGetRightChildTest
    {
        [Test]
        public void Max_Heap_Get_Right_Child_Test()
        {
            IBinaryHeap heap = new MaxHeap();
            heap.Push(1);
            heap.Push(2);
            heap.Push(3);
            heap.Push(4);
            heap.Push(5);
            heap.Push(6);

            heap.GetRightChild(0).Should().Be(5);
        }
    }
}