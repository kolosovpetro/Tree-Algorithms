﻿using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.AvlTests
{
    [TestFixture]
    public class AvlLeftRotateTest
    {
        // [Test]
        // public void AvlTree_LeftRotate_Simple_Test()
        // {
        //     // this requires left rotation
        //     var tree1 = new Implementations.BinarySearchTree(1);
        //     var tree2 = tree1.AvlInsert(2);
        //     var tree3 = tree1.AvlInsert(3);
        //
        //     tree1.Parent.Key.Should().Be(2);
        //     tree1.Left.Should().BeNull();
        //     tree1.Right.Should().BeNull();
        //     
        //     tree2.Parent.Should().BeNull();
        //     tree2.Left.Key.Should().Be(1);
        //     tree2.Right.Key.Should().Be(3);
        //     
        //     tree3.Parent.Key.Should().Be(2);
        //     tree3.Left.Should().BeNull();
        //     tree3.Right.Should().BeNull();
        // }
        
        [Test]
        public void AvlTree_LeftRotate_Simple_Test_2()
        {
            // this requires left rotation
            var tree1 = new Implementations.BinarySearchTree(1);
            var tree2 = tree1.BstInsert(2);
            var tree3 = tree1.BstInsert(3);
            var tree4 = tree1.BstInsert(4);

            var rotate = tree2.AvlLeftRotate();

            rotate.Parent.Key.Should().Be(3);
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();

            var parent = rotate.Parent;
            parent.Key.Should().Be(3);
            parent.Left.Key.Should().Be(2);
            parent.Right.Key.Should().Be(4);
            parent.Parent.Key.Should().Be(1);

            var grandParent = parent.Parent;
            grandParent.Parent.Should().BeNull();
            grandParent.Left.Should().BeNull();
            grandParent.Right.Key.Should().Be(3);
        }
        
    }
}