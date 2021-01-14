using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.AvlTests
{
    [TestFixture]
    public class AvlRightRotateTest
    {
        [Test]
        public void AvlTree_RightRotate_Test_1()
        {
            var tree = new Implementations.BinarySearchTree(10);
            var tree2 = tree.BstInsert(9);
            var tree3 = tree.BstInsert(8);

            var rotate = tree.AvlRightRotate();
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();
            rotate.Parent.Key.Should().Be(9);

            var parent = rotate.Parent;
            parent.Parent.Should().BeNull();
            parent.Key.Should().Be(9);
            parent.Right.Key.Should().Be(10);
            parent.Left.Key.Should().Be(8);

            var left = parent.Left;
            left.Left.Should().BeNull();
            left.Right.Should().BeNull();
            left.Parent.Key.Should().Be(9);
        }
        
        [Test]
        public void AvlTree_RightRotate_Test_2()
        {
            var tree = new Implementations.BinarySearchTree(10);
            var tree2 = tree.BstInsert(9);
            var tree3 = tree.BstInsert(8);
            var tree4 = tree.BstInsert(7);

            var rotate = tree2.AvlRightRotate();
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();
            rotate.Parent.Key.Should().Be(8);

            var parent = rotate.Parent;
            parent.Parent.Key.Should().Be(10);
            parent.Key.Should().Be(8);
            parent.Right.Key.Should().Be(9);
            parent.Left.Key.Should().Be(7);

            var left = parent.Left;
            left.Left.Should().BeNull();
            left.Right.Should().BeNull();
            left.Parent.Key.Should().Be(8);
            
            var grandParent = parent.Parent;
            grandParent.Left.Key.Should().Be(8);
            grandParent.Right.Should().BeNull();
            grandParent.Parent.Should().BeNull();
        }
        
        [Test]
        public void AvlTree_RightRotate_Test_3()
        {
            var tree1 = new Implementations.BinarySearchTree(2);
            var tree2 = tree1.BstInsert(1);

            var rotate = tree1.AvlRightRotate();
            rotate.Parent.Should().Be(tree2);
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();

            var parent = rotate.Parent;
            parent.Parent.Should().BeNull();
            parent.Left.Should().BeNull();
            parent.Right.Should().Be(tree1);
        }
    }
}