using FluentAssertions;
using NUnit.Framework;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.Tests.BinarySearchTreeTests
{
    [TestFixture]
    public class BstBalanceTest
    {
        [Test]
        public void Bst_Balance_Test_1()
        {
            IBinarySearchTree tree = new BinarySearchTree.Implementations.BinarySearchTree(50);
            var v2 = tree.BstInsert(2);
            var v3 = tree.BstInsert(3);
            var v4 = tree.BstInsert(4);
            
            tree.Balance.Should().Be(1);
            v2.Balance.Should().Be(2);
            v3.Balance.Should().Be(1);
            v4.Balance.Should().Be(0);
        }
        
        [Test]
        public void Bst_Balance_Test_2()
        {
            IBinarySearchTree tree = new BinarySearchTree.Implementations.BinarySearchTree(50);
            var v2 = tree.BstInsert(11);
            var v3 = tree.BstInsert(9);
            var v4 = tree.BstInsert(6);
            var v5 = tree.BstInsert(8);

            tree.Balance.Should().Be(1);
        }
    }
}