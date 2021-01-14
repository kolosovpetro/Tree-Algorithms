using FluentAssertions;
using NUnit.Framework;
using Trees.Heap.Implementations;
using Trees.Heap.Interfaces;

namespace Trees.Heap.Tests.Tests
{
    [TestFixture]
    public class MaxHeapInitializationTest
    {
        [Test]
        public void Max_Heap_Initialization_Test()
        {
            IBinaryHeap heap = new MaxHeap();
            heap.IsEmpty.Should().BeTrue();
            heap.Count.Should().Be(0);
        }
    }
}