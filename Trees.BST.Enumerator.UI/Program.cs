using System;
using Trees.BST.Enumerator.Interfaces;
using Trees.BST.Enumerator.Trees;

namespace Trees.BST.Enumerator.UI
{
    public static class Program
    {
        private static void Main()
        {
            var tree = new EnumerableBst(50);
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
            foreach (var node in (IBstDepthFirstEnumerable) tree)
                Console.Write(node.Key + " ");
        }
    }
}