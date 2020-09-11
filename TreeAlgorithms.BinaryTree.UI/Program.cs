using System;
using TreeAlgorithms.BinaryTree.Implementations;

namespace TreeAlgorithms.BinaryTree.UI
{
    public static class Program
    {
        private static void Main()
        {
            var f = new BinaryTree<char>('F');
            var b = new BinaryTree<char>('B');
            var g = new BinaryTree<char>('G');
            var a = new BinaryTree<char>('A');
            var d = new BinaryTree<char>('D');
            var i = new BinaryTree<char>('I');
            var c = new BinaryTree<char>('C');
            var e = new BinaryTree<char>('E');
            var h = new BinaryTree<char>('H');

            f.AddLeft(b);
            f.AddRight(g);
            b.AddLeft(a);
            b.AddRight(d);
            g.AddRight(i);
            i.AddLeft(h);
            d.AddLeft(c);
            d.AddRight(e);

            Console.WriteLine("PreOrder tree traversal: ");
            f.PreOrderTraversal(f);
            
            Console.WriteLine();
            Console.WriteLine("InOrder tree traversal: ");
            f.InOrderTraversal(f);
            
            Console.WriteLine();
            Console.WriteLine("OutOrder tree traversal: ");
            f.OutOrderTraversal(f);
            
            Console.WriteLine();
            Console.WriteLine("PostOrder tree traversal: ");
            f.PostOrderTraversal(f);

            Console.WriteLine();
            Console.WriteLine("LevelOrder tree traversal: ");
            f.BreadthFirstTreeTraversal(f);
        }
    }
}