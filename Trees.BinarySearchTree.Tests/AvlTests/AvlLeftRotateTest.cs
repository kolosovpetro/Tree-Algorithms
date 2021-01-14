using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.AvlTests
{
    [TestFixture]
    public class AvlLeftRotateTest
    {
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

            var parentRight = parent.Right;
            parentRight.Key.Should().Be(4);
            parentRight.Left.Should().BeNull();
            parentRight.Right.Should().BeNull();
            parentRight.Parent.Key.Should().Be(3);
        }
        
        [Test]
        public void AvlTree_LeftRotate_Simple_Test_3()
        {
            var tree1 = new Implementations.BinarySearchTree(1);
            var tree2 = tree1.BstInsert(2);
            var tree3 = tree1.BstInsert(3);
            var tree4 = tree1.BstInsert(4);

            var rotate = tree1.AvlLeftRotate();

            rotate.Parent.Key.Should().Be(2);
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();
            tree2.Balance.Should().Be(1);

            var parent = rotate.Parent;
            parent.Key.Should().Be(2);
            parent.Left.Key.Should().Be(1);
            parent.Right.Key.Should().Be(3);
            parent.Balance.Should().Be(1);

            var parentRight = parent.Right;
            parentRight.Key.Should().Be(3);
            parentRight.Left.Should().BeNull();
            parentRight.Right.Key.Should().Be(4);
            parentRight.Parent.Key.Should().Be(2);

            var parentRightRight = parentRight.Right;
            parentRightRight.Key.Should().Be(4);
            parentRightRight.Parent.Key.Should().Be(3);
            parentRightRight.Left.Should().BeNull();
            parentRightRight.Right.Should().BeNull();
        }
    }
}