using System;
using TreeAlgorithms.AvlTree.Interfaces;
using TreeAlgorithms.AvlTree.Rotations;

namespace TreeAlgorithms.AvlTree.UI
{
    public static class Program
    {
        private static void Main()
        {
            IAvlTree tree = new Implementations.AvlTree(3);
            tree.BstInsert(2);
            tree.BstInsert(4);
            tree.BstInsert(5);
            
            tree.PrintLevelOrder(tree);

            AvlRotation.LeftRotation(ref tree);
            Console.WriteLine();
            tree.PrintLevelOrder(tree);
        }
    }
}