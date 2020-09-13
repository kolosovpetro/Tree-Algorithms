using System;
using System.Collections.Generic;
using System.Linq;
using TreeAlgorithms.BinaryTree.Interfaces;

namespace TreeAlgorithms.BinaryTree.Implementations
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        public T Data { get; }
        public IBinaryTree<T> Root { get; set; }
        public IBinaryTree<T> Right { get; private set; }
        public IBinaryTree<T> Left { get; private set; }
        public IBinaryTree<T> Parent { get; set; }
        public bool IsEmpty => !HasLeft && !HasRight;
        public bool HasLeft => Left != null;
        public bool HasRight => Right != null;

        public BinaryTree(T data)
        {
            Data = data;
            Root = this;
        }

        public void AddRight(IBinaryTree<T> right)
        {
            Right = right;
            right.Parent = this;
        }

        public void AddLeft(IBinaryTree<T> left)
        {
            Left = left;
            left.Parent = this;
        }

        public bool IsInternal(IBinaryTree<T> binaryTree) => !binaryTree.IsEmpty;

        public bool IsExternal(IBinaryTree<T> binaryTree) => binaryTree.IsEmpty;

        public int Depth(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == Root) return 0;
            return 1 + Depth(binaryTree.Parent);
        }

        public int Height(IBinaryTree<T> binaryTree)
        {
            if (IsExternal(binaryTree)) return 0;
            var height = 0;

            if (binaryTree.HasLeft)
                height = height > Height(binaryTree.Left) ? height : Height(binaryTree.Left);
            if (binaryTree.HasRight)
                height = height > Height(binaryTree.Right) ? height : Height(binaryTree.Right);

            return height + 1;
        }

        // NLR
        public void PreOrderTraversal(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == null) return;
            Console.Write(binaryTree.Data + " ");
            PreOrderTraversal(binaryTree.Left);
            PreOrderTraversal(binaryTree.Right);
        }

        // LNR
        public void InOrderTraversal(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == null) return;
            InOrderTraversal(binaryTree.Left);
            Console.Write(binaryTree.Data + " ");
            InOrderTraversal(binaryTree.Right);
        }

        // RNL
        public void OutOrderTraversal(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == null) return;
            OutOrderTraversal(binaryTree.Right);
            Console.Write(binaryTree.Data + " ");
            OutOrderTraversal(binaryTree.Left);
        }

        // LRN
        public void PostOrderTraversal(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == null) return;
            PostOrderTraversal(binaryTree.Left);
            PostOrderTraversal(binaryTree.Right);
            Console.Write(binaryTree.Data + " ");
        }

        public void BreadthFirstTreeTraversal(IBinaryTree<T> binaryTree)
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