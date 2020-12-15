using FluentAssertions;
using NUnit.Framework;
using Trees.Heap.Implementations;
using Trees.Heap.Interfaces;

namespace Trees.Tests.BinaryHeapTests.MaxHeapTests
{
    [TestFixture]
    public class MaxHeapPushTest
    {
        [Test]
        public void Max_Heap_Push_Test_1()
        {
            IBinaryHeap heap = new MaxHeap();
            heap.Push(8);
            heap.Push(10);
            heap.Push(11);
            heap.Pop().Should().Be(11);
            heap.Pop().Should().Be(10);
            heap.Pop().Should().Be(8);
        }
    }
}