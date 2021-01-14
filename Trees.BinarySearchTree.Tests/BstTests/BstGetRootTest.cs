using FluentAssertions;
using NUnit.Framework;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Tests.BstTests
{
    [TestFixture]
    public class BstGetRootTest
    {
        [Test]
        public void Bst_Get_Root_Test()
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
            var last = tree.BstInsert(19);

            tree.GetRoot().Key.Should().Be(50);
            last.GetRoot().Key.Should().Be(50);
        }
    }
}