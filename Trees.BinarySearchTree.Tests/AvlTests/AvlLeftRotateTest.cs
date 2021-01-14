﻿using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.AvlTests
{
    [TestFixture]
    public class AvlLeftRotateTest
    {
        [Test]
        public void AvlTree_LeftRotate_Simple_Test()
        {
            // this requires left rotation
            var tree1 = new Implementations.BinarySearchTree(1);
            var tree2 = tree1.AvlInsert(2);
            var tree3 = tree1.AvlInsert(3);
            
            tree1.Parent.Should().Be(tree2);
            tree1.Left.Should().BeNull();
            tree1.Right.Should().BeNull();

            tree2.Parent.Should().BeNull();
            tree2.Left.Should().Be(tree1);
            tree2.Right.Should().Be(tree3);

            tree3.Parent.Should().Be(tree2);
            tree3.Left.Should().BeNull();
            tree3.Right.Should().BeNull();
        }
    }
}