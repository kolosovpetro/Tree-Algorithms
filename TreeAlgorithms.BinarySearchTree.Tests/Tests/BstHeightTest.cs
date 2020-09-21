using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.BinarySearchTree.Interfaces;

namespace TreeAlgorithms.BinarySearchTree.Tests.Tests
{
    [TestFixture]
    public class BstHeightTest
    {
        [Test]
        public void Bst_Height_Test()
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

            tree.Height(tree).Should().Be(3);
            tree.Height(tree.Left).Should().Be(2);
        }
    }
}