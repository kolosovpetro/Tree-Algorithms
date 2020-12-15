using System;
using Trees.BST.Implementations;

namespace Trees.TraversalEngine.UI
{
    public static class Program
    {
        private static void Main()
        {
            var tree = new BinarySearchTree(50);
            tree.BstInsert(72);
            tree.BstInsert(54);
            tree.BstInsert(76);
            tree.BstInsert(67);
            tree.BstInsert(17);
            tree.BstInsert(12);
            tree.BstInsert(23);
            tree.BstInsert(9);
            tree.BstInsert(14);
            tree.BstInsert(19);

            var traversalEngine = new Trees.TraversalEngine.Implementations.TraversalEngine();
            var inOrderIterative = traversalEngine.InOrderTraversalIterative(tree);
            foreach (var node in inOrderIterative)
            {
                Console.Write(node.Key + " ");
            }

            Console.WriteLine();

            var preOrderIterative = traversalEngine.PreOrderTraversalIterative(tree);
            foreach (var node in preOrderIterative)
            {
                Console.Write(node.Key + " ");
            }

            Console.WriteLine();

            var postOrderIterative = traversalEngine.PostOrderTraversalIterative(tree);
            foreach (var node in postOrderIterative)
            {
                Console.Write(node.Key + " ");
            }

            Console.WriteLine();

            var breadthFirstTraversalIterative = traversalEngine.BreadthFirstTraversalIterative(tree);
            foreach (var node in breadthFirstTraversalIterative)
            {
                Console.Write(node.Key + " ");
            }
        }
    }
}