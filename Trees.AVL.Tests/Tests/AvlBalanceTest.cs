using FluentAssertions;
using NUnit.Framework;
using Trees.AVL.Implementations;
using Trees.AVL.Interfaces;

namespace Trees.AVL.Tests.Tests
{
    [TestFixture]
    public class AvlBalanceTest
    {
        [Test]
        public void Bst_Balance_Test_1()
        {
            IAvlTree tree = new AvlTree(3);
            var v2 = tree.BstInsert(4);
            var v3 = tree.BstInsert(5);

            tree.Height.Should().Be(2);

            tree.Balance.Should().Be(2);
            // v2.Should().Be(1);
            // tree.CalculateBalance(v3).Should().Be(0);
        }

        [Test]
        public void Bst_Balance_Test_2()
        {
            // IAvlTree tree = new AvlTree(50);
            // var v2 = tree.BstInsert(11);
            // var v3 = tree.BstInsert(9);
            // var v4 = tree.BstInsert(6);
            // var v5 = tree.BstInsert(8);
            //
            // tree.CalculateBalance(tree).Should().Be(1);
        }
    }
}