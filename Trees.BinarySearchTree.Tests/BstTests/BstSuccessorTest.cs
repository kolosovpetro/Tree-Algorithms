using FluentAssertions;
using NUnit.Framework;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Tests.BstTests
{
    [TestFixture]
    public class BstSuccessorTest
    {
        [Test]
        public void Bst_Successor_Test()
        {
            IBinarySearchTree tree = new Implementations.BinarySearchTree(50);
            
            // sub tree 1
            tree.BstInsert(72);
            tree.BstInsert(54);
            tree.BstInsert(76);
            tree.BstInsert(67);
            
            // sub tree 2
            tree.BstInsert(17);
            tree.BstInsert(12);
            tree.BstInsert(23);
            tree.BstInsert(9);
            tree.BstInsert(14);
            tree.BstInsert(19);

            tree.Successor(tree).Key.Should().Be(54);
            tree.Successor(tree.Left).Key.Should().Be(19);
        }
    }
}