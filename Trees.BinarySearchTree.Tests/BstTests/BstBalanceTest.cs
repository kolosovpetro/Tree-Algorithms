using FluentAssertions;
using NUnit.Framework;

namespace Trees.BinarySearchTree.Tests.BstTests
{
    [TestFixture]
    public class BstBalanceTest
    {
        [Test]
        public void Bst_Balance_Test()
        {
            var bst = new Implementations.BinarySearchTree(2);
            var b1 = bst.BstInsert(3);
            var b2 = bst.BstInsert(4);
            bst.Balance.Should().Be(2);
            b1.Balance.Should().Be(1);
            b2.Balance.Should().Be(0);
        }
        
        [Test]
        public void Bst_Balance_Test_2()
        {
            var bst = new Implementations.BinarySearchTree(50);
            var b1 = bst.BstInsert(2);
            var b2 = bst.BstInsert(3);
            var b3 = bst.BstInsert(4);
            bst.Balance.Should().Be(-3);
            b1.Balance.Should().Be(2);
            b2.Balance.Should().Be(1);
            b3.Balance.Should().Be(0);
        }
    }
}