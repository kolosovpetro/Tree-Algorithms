﻿using FluentAssertions;
using NUnit.Framework;
using Trees.Heap.Implementations;
using Trees.Heap.Interfaces;

namespace Trees.Heap.Tests.Tests
{
    [TestFixture]
    public class MaxHeapGetParentTest
    {
        [Test]
        public void Max_Heap_Get_Parent_Test()
        {
            IBinaryHeap heap = new MaxHeap();
            heap.Push(1);
            heap.Push(2);
            heap.Push(3);
            heap.Push(4);
            heap.Push(5);
            heap.Push(6);

            heap.GetParent(4).Should().Be(4);
            heap.GetParent(5).Should().Be(5);
        }
    }
}