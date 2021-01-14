using System;
using System.Collections.Generic;
using Trees.BinaryTree.Interfaces;

namespace Trees.BinaryTree.Implementations
{
    public static class DisplayTree
    {
        // NLR
        public static void PreOrderTraversal<T>(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == null) return;
            Console.Write(binaryTree.Data + " ");
            PreOrderTraversal(binaryTree.Left);
            PreOrderTraversal(binaryTree.Right);
        }

        // LNR
        public static void InOrderTraversal<T>(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == null) return;
            InOrderTraversal(binaryTree.Left);
            Console.Write(binaryTree.Data + " ");
            InOrderTraversal(binaryTree.Right);
        }

        // RNL
        public static void OutOrderTraversal<T>(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == null) return;
            OutOrderTraversal(binaryTree.Right);
            Console.Write(binaryTree.Data + " ");
            OutOrderTraversal(binaryTree.Left);
        }

        // LRN
        public static void PostOrderTraversal<T>(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == null) return;
            PostOrderTraversal(binaryTree.Left);
            PostOrderTraversal(binaryTree.Right);
            Console.Write(binaryTree.Data + " ");
        }

        public static void BreadthFirstTreeTraversal<T>(IBinaryTree<T> binaryTree)
        {
            var queue = new Queue<IBinaryTree<T>>();
            queue.Enqueue(binaryTree);

            while (queue.Count > 0)
            {
                var currentTree = queue.Dequeue();
                Console.Write(currentTree.Data + " ");
                if (currentTree.HasLeft) queue.Enqueue(currentTree.Left);
                if (currentTree.HasRight) queue.Enqueue(currentTree.Right);
            }
        }
    }
}