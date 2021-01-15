using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.AvlTests
{
    [TestFixture]
    public class AvlLeftRotateTest
    {
        [Test]
        public void AvlTree_LeftRotate_Simple_Test_1()
        {
            // this requires left rotation
            var tree1 = new Implementations.BinarySearchTree(1);
            var tree2 = tree1.BstInsert(2);
            var tree3 = tree1.BstInsert(3);

            var rotate = tree1.AvlLeftRotate();

            rotate.Parent.Key.Should().Be(2);
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();

            var parent = rotate.Parent;
            parent.Key.Should().Be(2);
            parent.Left.Key.Should().Be(1);
            parent.Right.Key.Should().Be(3);
            parent.Parent.Should().BeNull();

            var parentRight = parent.Right;
            parentRight.Key.Should().Be(3);
            parentRight.Left.Should().BeNull();
            parentRight.Right.Should().BeNull();
            parentRight.Parent.Key.Should().Be(2);
        }
        
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
        public void AvlTree_LeftRotate_Simple_Test_4()
        {
            var tree1 = new Implementations.BinarySearchTree(1);
            var tree2 = tree1.BstInsert(2);

            var rotate = tree1.AvlLeftRotate();
            rotate.Key.Should().Be(1);
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();
            rotate.Parent.Should().Be(tree2);

            tree2.Parent.Should().BeNull();
            tree2.Left.Should().Be(tree1);
            tree2.Right.Should().BeNull();
        }
        
        [Test]
        public void AvlTree_LeftRotation_Test_5()
        {
            var tree1 = new Implementations.BinarySearchTree(45);
            var tree2 = tree1.BstInsert(13);
            var tree3 = tree1.BstInsert(29);

            var rotate = tree2.AvlLeftRotate();
            rotate.Key.Should().Be(13);
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();
            rotate.Parent.Should().Be(tree3);

            var parent = rotate.Parent;
            parent.Key.Should().Be(29);
            parent.Left.Should().Be(tree2);
            parent.Right.Should().BeNull();
            parent.Parent.Should().Be(tree1);

            var grandParent = parent.Parent;
            grandParent.Parent.Should().BeNull();
            grandParent.Right.Should().BeNull();
            grandParent.Left.Should().Be(tree3);
        }
    }
}