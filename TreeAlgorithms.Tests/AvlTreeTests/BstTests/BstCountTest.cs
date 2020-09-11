using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.Tests.AvlTreeTests.BstTests
{
    [TestFixture]
    public class BstCountTest
    {
        [Test]
        public void Bst_Count_Test()
        {
            IAvlTree tree = new AvlTree.Implementations.AvlTree(50);
            
            // sub tree 1
            var countTest1 = tree.BstInsert(72);
            tree.BstInsert(54);
            tree.BstInsert(76); 
            tree.BstInsert(67);
            
            // sub tree 2
            var countTest2 = tree.BstInsert(17);
            tree.BstInsert(12);
            tree.BstInsert(23);
            tree.BstInsert(9);
            tree.BstInsert(14);
            tree.BstInsert(19);

            countTest1.Count().Should().Be(4);
            countTest2.Count().Should().Be(6);
            
        }
    }
}