﻿using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.BinarySearchTree.Interfaces;

namespace TreeAlgorithms.BinarySearchTree.Tests.Tests
{
    [TestFixture]
    public class BstInsertTest
    {
        [Test]
        public void Bst_Insert_Test()
        {
            IBinarySearchTree tree = new Implementations.BinarySearchTree(50);
            
            // sub tree 1
            var test = tree.BstInsert(72);
            tree.BstInsert(54);
            tree.BstInsert(76); 
            tree.BstInsert(67);
            
            // sub tree 2
            tree.BstInsert(17);
            tree.BstInsert(12);
            tree.BstInsert(23);
            tree.BstInsert(9);
            tree.BstInsert(14);
            tree.BstInsert(19);

            tree.Root.Key.Should().Be(50);
            tree.Right.Key.Should().Be(72);
            tree.Count.Should().Be(11);
            test.Parent.Key.Should().Be(50);
        }
    }
}