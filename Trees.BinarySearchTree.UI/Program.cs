using System;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.BST.UI
{
    public static class Program
    {
        private static void Main()
        {
            IBinarySearchTree tree = new BinarySearchTree.Implementations.BinarySearchTree(50);
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

            Console.WriteLine("In order: ");
            foreach (var node in (IBstInOrderEnumerable) tree)
                Console.Write(node.Key + " ");
            Console.WriteLine("\nPost order: ");
            foreach (var node in (IBstPostOrderEnumerable) tree)
                Console.Write(node.Key + " ");
            Console.WriteLine("\nPre order: ");
            foreach (var node in (IBstPreOrderEnumerable) tree)
                Console.Write(node.Key + " ");
            Console.WriteLine("\nLevel order: ");
            foreach (var node in (IBstBreadthFirstEnumerable) tree)
                Console.Write(node.Key + " ");
        }
    }
}