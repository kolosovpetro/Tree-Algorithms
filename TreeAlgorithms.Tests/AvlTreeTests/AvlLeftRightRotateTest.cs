using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.Tests.AvlTreeTests
{
    [TestFixture]
    public class AvlLeftRightRotateTest
    {
        [Test]
        public void AvlTree_Left_Right_Rotate_Test()
        {
            IAvlTree node1 = new AvlTree.Implementations.AvlTree(45);
            var node2 = node1.BstInsert(13);
            var node3 = node1.BstInsert(29);

            node1.LeftRightRotate();

            node1.Parent.Key.Should().Be(29);
            node1.Parent.Left.Key.Should().Be(13);
            node1.Parent.Right.Key.Should().Be(45);
        }
    }
}