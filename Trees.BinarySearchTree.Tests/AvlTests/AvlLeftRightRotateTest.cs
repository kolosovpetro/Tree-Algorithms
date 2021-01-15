using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.AvlTests
{
    [TestFixture]
    public class AvlLeftRightRotateTest
    {
        [Test]
        public void AvlTree_LeftRightRotation_Test_1()
        {
            var tree1 = new Implementations.BinarySearchTree(45);
            var tree2 = tree1.BstInsert(13);
            var tree3 = tree1.BstInsert(29);

            var rotate = tree2.AvlLeftRightRotate();
            var parent = rotate.Parent;
            rotate.Key.Should().Be(45);
            rotate.Left.Should().BeNull();
            rotate.Right.Should().BeNull();
            rotate.Parent.Should().Be(tree3);
            
            parent.Parent.Should().BeNull();
            parent.Key.Should().Be(29);
            parent.Left.Should().Be(tree2);
            parent.Right.Should().Be(tree1);
        }
    }
}