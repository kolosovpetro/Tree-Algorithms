using FluentAssertions;
using NUnit.Framework;
using Trees.BinaryTree.Implementations;
using Trees.BinaryTree.Interfaces;

namespace Trees.BinaryTree.Tests.BinaryTreeTests
{
    [TestFixture]
    public class TreeIsEmptyTest
    {
        [Test]
        public void Tree_Is_Empty_Test()
        {
            IBinaryTree<char> f = new BinaryTree<char>('F');
            IBinaryTree<char> b = new BinaryTree<char>('B');
            IBinaryTree<char> g = new BinaryTree<char>('G');
            IBinaryTree<char> a = new BinaryTree<char>('A');
            IBinaryTree<char> d = new BinaryTree<char>('D');
            IBinaryTree<char> i = new BinaryTree<char>('I');
            IBinaryTree<char> c = new BinaryTree<char>('C');
            IBinaryTree<char> e = new BinaryTree<char>('E');
            IBinaryTree<char> h = new BinaryTree<char>('H');

            f.AddLeft(b);
            f.AddRight(g);
            b.AddLeft(a);
            b.AddRight(d);
            g.AddRight(i);
            d.AddLeft(c);
            d.AddRight(e);
            i.AddLeft(h);

            f.IsEmpty.Should().BeFalse();
            h.IsEmpty.Should().BeTrue();
            a.IsEmpty.Should().BeTrue();
        }
    }
}