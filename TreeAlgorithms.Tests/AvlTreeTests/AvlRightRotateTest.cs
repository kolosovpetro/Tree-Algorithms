using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.Tests.AvlTreeTests
{
    [TestFixture]
    public class AvlRightRotateTest
    {
        [Test]
        public void Avl_Tree_Right_Rotate_Test_1()
        {
            IAvlTree root = new AvlTree.Implementations.AvlTree(12);
            root.BstInsert(9);
            root.BstInsert(3);

            root.RightRotate();

            root.Parent.Key.Should().Be(9);
            root.Parent.Right.Key.Should().Be(12);
            root.Parent.Left.Key.Should().Be(3);
        }

        [Test]
        public void Avl_Tree_Right_Rotate_Test_2()
        {
            IAvlTree node1 = new AvlTree.Implementations.AvlTree(12);
            var node2 = node1.BstInsert(9);
            var node3 = node1.BstInsert(8);
            var node4 = node1.BstInsert(5);
            var node5 = node1.BstInsert(3);

            node2.RightRotate();
            
            // check node 2
            var parent = node2.Parent;
            parent.Key.Should().Be(8);
            parent.Right.Key.Should().Be(9);
            parent.Left.Key.Should().Be(5);

            parent.Parent.Key.Should().Be(12);
        }
        
        [Test]
        public void Avl_Tree_Right_Rotate_Test_3()
        {
            IAvlTree node1 = new AvlTree.Implementations.AvlTree(12);
            var node2 = node1.BstInsert(9);

            node1.RightRotate();

            node1.Parent.Key.Should().Be(9);
            node1.Parent.Right.Key.Should().Be(12);
        }
    }
}