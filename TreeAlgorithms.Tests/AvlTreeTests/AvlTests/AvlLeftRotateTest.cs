using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.Tests.AvlTreeTests.AvlTests
{
    [TestFixture]
    public class AvlLeftRotateTest
    {
        [Test]
        public void AvlTree_Left_Rotate_Test_1()
        {
            IAvlTree tree = new AvlTree.Implementations.AvlTree(1);
            tree.BstInsert(2);
            tree.BstInsert(3);

            tree.LeftRotate();

            tree.Key.Should().Be(1);
            tree.Right.Should().BeNull();
            tree.Parent.Key.Should().Be(2);
            tree.Parent.Right.Key.Should().Be(3);
        }

        [Test]
        public void AvlTree_Left_Rotate_Test_2()
        {
            IAvlTree node1 = new AvlTree.Implementations.AvlTree(1);
            var node2 = node1.BstInsert(2);
            var node3 = node1.BstInsert(3);
            var node4 = node1.BstInsert(4);
            var node5 = node1.BstInsert(5);

            node3.LeftRotate();
            
            // check node 3
            node3.Parent.Key.Should().Be(4);
            node3.Parent.Left.Key.Should().Be(3);
            node3.Parent.Right.Key.Should().Be(5);

            node1.Key.Should().Be(1);
            node1.Left.Should().BeNull();
            node1.Right.Key.Should().Be(2);
            node1.Right.Right.Key.Should().Be(4);
            node1.Right.Right.Right.Key.Should().Be(5);
            node1.Right.Right.Left.Key.Should().Be(3);
        }
        
        [Test]
        public void AvlTree_Left_Rotate_Test_3()
        {
            IAvlTree node1 = new AvlTree.Implementations.AvlTree(1);
            var node2 = node1.BstInsert(2);
            var node3 = node1.BstInsert(3);
            var node4 = node1.BstInsert(4);
            var node5 = node1.BstInsert(5);

            node1.LeftRotate();

            node1.Parent.Key.Should().Be(2);
            node1.Parent.Left.Key.Should().Be(1);
            node1.Parent.Right.Key.Should().Be(3);
            node1.Parent.Right.Right.Key.Should().Be(4);
            node1.Parent.Right.Right.Right.Key.Should().Be(5);
        }
        
        [Test]
        public void AvlTree_Left_Rotate_Test_4()
        {
            IAvlTree node1 = new AvlTree.Implementations.AvlTree(1);
            var node2 = node1.BstInsert(2);

            node1.LeftRotate();

            node1.Parent.Key.Should().Be(2);
            node1.Parent.Left.Key.Should().Be(1);
        }
    }
}