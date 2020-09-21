using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;
using TreeAlgorithms.AvlTree.Rotations;

namespace TreeAlgorithms.AvlTree.Tests.RotationTests
{
    [TestFixture]
    public class LeftRotationTest
    {
        [Test]
        public void Simple_Test()
        {
            IAvlTree tree = new Implementations.AvlTree(3);
            tree.BstInsert(2);
            tree.BstInsert(4);
            tree.BstInsert(5);

            tree.Key.Should().Be(3);
            tree.Left.Key.Should().Be(2);
            tree.Right.Key.Should().Be(4);
            tree.Right.Right.Key.Should().Be(5);
            
            AvlRotation.LeftRotation(ref tree);

            tree.Key.Should().Be(4);
            tree.Left.Key.Should().Be(3);
            tree.Right.Key.Should().Be(5);
            tree.Left.Left.Key.Should().Be(2);
        }
    }
}