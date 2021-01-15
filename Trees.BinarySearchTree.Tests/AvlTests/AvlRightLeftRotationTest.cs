using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.AvlTests
{
    [TestFixture]
    public class AvlRightLeftRotationTest
    {
        [Test]
        public void AvlTree_RightLeftRotation_Test_1()
        {
            var tree1 = new Implementations.BinarySearchTree(36);
            var tree2 = tree1.BstInsert(67);
            var tree3 = tree1.BstInsert(42);

            var rotate = tree2.AvlRightLeftRotate();
            rotate.Key.Should().Be(36);
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();
            rotate.Parent.Should().Be(tree3);

            var parent = rotate.Parent;
            parent.Key.Should().Be(42);
            parent.Left.Should().Be(tree1);
            parent.Right.Should().Be(tree2);
            parent.Parent.Should().BeNull();

            var right = parent.Right;
            right.Key.Should().Be(67);
            right.Left.Should().BeNull();
            right.Right.Should().BeNull();
            right.Parent.Should().Be(tree3);
        }
    }
}