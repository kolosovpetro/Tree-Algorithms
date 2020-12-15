using FluentAssertions;
using NUnit.Framework;
using Trees.BST.Implementations;
using Trees.BST.Interfaces;

namespace Trees.Tests.BinarySearchTreeTests
{
    [TestFixture]
    public class BstMaxTest
    {
        [Test]
        public void Bst_Max_Test()
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

            tree.Max().Key.Should().Be(76);
        }
    }
}