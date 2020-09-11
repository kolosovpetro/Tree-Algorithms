using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.BinaryHeap.Implementations;
using TreeAlgorithms.BinaryHeap.Interfaces;

namespace TreeAlgorithms.Tests.BinaryHeapTests.MaxHeapTests
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