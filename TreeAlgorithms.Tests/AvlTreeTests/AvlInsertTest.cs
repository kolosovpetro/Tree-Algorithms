using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.Tests.AvlTreeTests
{
    [TestFixture]
    public class AvlInsertTest
    {
        [Test]
        public void AvlTree_Insert_Test_1()
        {
            IAvlTree tree = new AvlTree.Implementations.AvlTree(1);
            var node1 = tree.AvlInsert(2);
            var node2 = tree.AvlInsert(3);

            tree.Balance.Should().Be(0);
            node1.Balance.Should().Be(0);
            node2.Balance.Should().Be(0);
            
            tree.Key.Should().Be(1);
            tree.Right.Should().BeNull();
            tree.Parent.Key.Should().Be(2);
            tree.Parent.Right.Key.Should().Be(3);
        }
    }
}