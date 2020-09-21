using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.AvlTree.Tests.AvlFunctionalityTests
{
    [TestFixture]
    public class LeftRotateTest
    {
        [Test]
        public void Simple_Test()
        {
            IAvlTree tree = new Implementations.AvlTree(1);
            tree.BstInsert(2);
            tree.BstInsert(3);

            tree.LeftRotate();
            
            tree.Key.Should().Be(2);
            tree.Left.Key.Should().Be(1);
            tree.Right.Key.Should().Be(3);
        }

        [Test]
        public void Simple_Test2()
        {
            IAvlTree tree = new Implementations.AvlTree(1);
            var node2 = tree.BstInsert(2);
            tree.BstInsert(3);
            tree.BstInsert(4);

            node2.LeftRotate();
            tree.Key.Should().Be(1);
            tree.Right.Key.Should().Be(3);
            tree.Right.Left.Key.Should().Be(2);
            tree.Right.Right.Key.Should().Be(4);
        }

        [Test]
        public void More_Complicated_Test()
        {
            IAvlTree tree = new Implementations.AvlTree(31);
            tree.BstInsert(12);
            tree.BstInsert(56);
            tree.BstInsert(32);
            tree.BstInsert(72);

            tree.Key.Should().Be(31);
            tree.Left.Key.Should().Be(12);
            tree.Right.Key.Should().Be(56);
            tree.Right.Right.Key.Should().Be(72);
            tree.Right.Left.Key.Should().Be(32);
        }
    }
}