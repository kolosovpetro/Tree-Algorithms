using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.Tests.AvlTreeTests.AvlTests
{
    [TestFixture]
    public class AvlRightLeftRotateTest
    {
        [Test]
        public void AvlTree_Right_Left_Rotate_Test_1()
        {
            IAvlTree node1 = new AvlTree.Implementations.AvlTree(36);
            var node2 = node1.BstInsert(67);
            var node3 = node1.BstInsert(42);

            node1.RightLeftRotate();

            node1.Parent.Key.Should().Be(42);
            node1.Parent.Left.Key.Should().Be(36);
            node1.Parent.Right.Key.Should().Be(67);
        }
    }
}