using System;
using TreeAlgorithms.BinarySearchTree.Interfaces;

namespace TreeAlgorithms.BinarySearchTree.Implementations
{
    public class BinarySearchTree : IBinarySearchTree
    {
        public int Key { get; set; }
        public int Balance => Height(Root) - Height(Left);
        public IBinarySearchTree Parent { get; set; }
        public IBinarySearchTree Left { get; set; }
        public IBinarySearchTree Right { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty => !HasLeft && !HasRight;
        public bool HasLeft => Left != null;
        public bool HasRight => Right != null;
        public IBinarySearchTree Root { get; set; }

        public BinarySearchTree(int key)
        {
            Key = key;
            Root = this;
            Count = 1;
        }

        public IBinarySearchTree Search(int key)
        {
            var currentNode = Root;

            while (currentNode != null && currentNode.Key != key)
                currentNode = key < currentNode.Key ? currentNode.Left : currentNode.Right;

            return currentNode;
        }

        public IBinarySearchTree BstInsert(int key)
        {
            IBinarySearchTree currentParent = null;
            var currentNode = Root;

            while (currentNode != null)
            {
                currentParent = currentNode;
                currentNode = key <= currentNode.Key ? currentNode.Left : currentNode.Right;
            }

            currentNode = new BinarySearchTree(key) {Parent = currentParent};

            if (currentParent == null)
                Root = currentNode;
            else if (key <= currentParent.Key)
                currentParent.Left = currentNode;
            else
                currentParent.Right = currentNode;

            Count++;
            return currentNode;
        }

        public IBinarySearchTree BstDelete(IBinarySearchTree binarySearchTree)
        {
            if (binarySearchTree.Left == null)
                return Transplant(binarySearchTree, binarySearchTree.Right);

            if (binarySearchTree.Right == null)
                return Transplant(binarySearchTree, binarySearchTree.Right);

            var successor = binarySearchTree.Right.Min();

            if (successor.Parent != binarySearchTree)
            {
                Transplant(successor, successor.Right);
                successor.Right = binarySearchTree.Right;
                successor.Right.Parent = successor;
            }

            Transplant(binarySearchTree, successor);
            successor.Left = binarySearchTree.Left;
            successor.Left.Parent = successor;
            Count--;
            return successor;
        }

        public IBinarySearchTree Max()
        {
            var node = Root;

            while (node.Right != null)
                node = node.Right;

            return node;
        }

        public IBinarySearchTree Min()
        {
            var node = Root;

            while (node.Left != null)
                node = node.Left;

            return node;
        }

        public IBinarySearchTree Successor(IBinarySearchTree binarySearchTree)
        {
            if (binarySearchTree.Right != null)
                return binarySearchTree.Right.Min();

            var currentParent = binarySearchTree.Parent;

            while (currentParent != null && binarySearchTree == currentParent.Right)
            {
                binarySearchTree = currentParent;
                currentParent = currentParent.Parent;
            }

            return currentParent;
        }

        public bool IsExternal(IBinarySearchTree tree) => tree.IsEmpty;

        public int Height(IBinarySearchTree tree)
        {
            if (tree == null) return 0;
            if (IsExternal(tree)) return 0;
            var height = 0;

            if (tree.HasLeft)
                height = height > Height(tree.Left) ? height : Height(tree.Left);
            if (tree.HasRight)
                height = height > Height(tree.Right) ? height : Height(tree.Right);

            return height + 1;
        }

        private static void InOrder(IBinarySearchTree binarySearchTree)
        {
            if (binarySearchTree == null) return;
            InOrder(binarySearchTree.Left);
            Console.Write($"{binarySearchTree.Key} ");
            InOrder(binarySearchTree.Right);
        }

        public void PrintSorted() => InOrder(Root);

        private IBinarySearchTree Transplant(IBinarySearchTree originalBst, IBinarySearchTree replacementBst)
        {
            if (originalBst.Parent == null)
                Root = replacementBst;

            else if (originalBst == originalBst.Parent.Left)
                originalBst.Parent.Left = replacementBst;
            else
                originalBst.Parent.Right = replacementBst;

            if (replacementBst != null)
                replacementBst.Parent = originalBst.Parent;

            return replacementBst;
        }
    }
}