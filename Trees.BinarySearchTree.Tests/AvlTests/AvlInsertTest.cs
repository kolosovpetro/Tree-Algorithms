using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.AvlTests
{
    [TestFixture]
    public class AvlInsertTest
    {
        [Test]
        public void AvlInsert_Test_1()
        {
            var tree1 = new Implementations.BinarySearchTree(1);
            var tree2 = tree1.AvlInsert(2);
            var tree3 = tree1.AvlInsert(3);

            tree1.Parent.Key.Should().Be(2);
            tree1.Left.Should().BeNull();
            tree1.Right.Should().BeNull();

            var parent = tree1.Parent;
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
    }
}