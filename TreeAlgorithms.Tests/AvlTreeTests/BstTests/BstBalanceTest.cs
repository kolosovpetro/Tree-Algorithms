using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.Tests.AvlTreeTests.BstTests
{
    [TestFixture]
    public class BstBalanceTest
    {
        [Test]
        public void Bst_Balance_Test_1()
        {
            IAvlTree tree = new AvlTree.Implementations.AvlTree(1);
            var v2 = tree.BstInsert(2);
            var v3 = tree.BstInsert(3);
            var v4 = tree.BstInsert(4);
            
            tree.Balance.Should().Be(3);
            v2.Balance.Should().Be(2);
            v3.Balance.Should().Be(1);
            v4.Balance.Should().Be(0);
        }
        
        [Test]
        public void Bst_Balance_Test_2()
        {
            IAvlTree tree = new AvlTree.Implementations.AvlTree(15);
            var v2 = tree.BstInsert(11);
            var v3 = tree.BstInsert(9);
            var v4 = tree.BstInsert(6);
            var v5 = tree.BstInsert(8);

            tree.Balance.Should().Be(1);
        }
    }
}