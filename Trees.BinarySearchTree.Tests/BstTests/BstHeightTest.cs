using FluentAssertions;
using NUnit.Framework;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Tests.BstTests
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

            tree.Height.Should().Be(3);
            tree.Left.Height.Should().Be(2);

            var balance = tree.Left.Height - tree.Right.Height;
            balance.Should().Be(0);
        }

        [Test]
        public void Bst_Height_Simple_Test()
        {
            IBinarySearchTree root = new Implementations.BinarySearchTree(2);
            var b1 = root.BstInsert(3);
            var b2 = root.BstInsert(4);
            root.Height.Should().Be(2);
            b1.Height.Should().Be(1);
            b2.Height.Should().Be(0);
        }
    }
}