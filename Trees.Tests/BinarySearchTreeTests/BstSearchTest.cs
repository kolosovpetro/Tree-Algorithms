using FluentAssertions;
using NUnit.Framework;
using Trees.BST.Implementations;
using Trees.BST.Interfaces;

namespace Trees.Tests.BinarySearchTreeTests
{
    [TestFixture]
    public class BstSearchTest
    {
        [Test]
        public void Bst_Search_Test()
        {
            IBinarySearchTree tree = new BinarySearchTree(50);
            
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

            tree.Search(14).Should().NotBeNull();
            tree.Search(14).Key.Should().Be(14);
            tree.Search(14).Parent.Key.Should().Be(12);
        }
    }
}