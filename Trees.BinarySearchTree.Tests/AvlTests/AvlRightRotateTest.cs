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
    }
}