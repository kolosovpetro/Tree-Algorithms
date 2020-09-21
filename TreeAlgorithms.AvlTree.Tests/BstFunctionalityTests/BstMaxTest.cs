﻿using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.AvlTree.Tests.BstFunctionalityTests
{
    [TestFixture]
    public class BstMaxTest
    {
        [Test]
        public void Bst_Max_Test()
        {
            IAvlTree tree = new Implementations.AvlTree(50);
            
            // sub tree 1
            tree.BstInsert(72);
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

            tree.Max().Key.Should().Be(76);
        }
    }
}