using System;
using System.Collections.Generic;
using System.Linq;
using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.AvlTree.Implementations
{
    public class AvlTree : IAvlTree
    {
        public int Key { get; set; }
        public bool IsExternal => !HasLeft && !HasRight;
        public bool HasLeft => Left != null;
        public bool HasRight => Right != null;
        public int Balance => Height(this) - Height(Left);
        public IAvlTree Parent { get; set; }
        public IAvlTree Left { get; set; }
        public IAvlTree Right { get; set; }

        public AvlTree(int key) => Key = key;

        public IAvlTree Search(int key)
        {
            var currentNode = this;

            while (currentNode != null && currentNode.Key != key)
                currentNode = (AvlTree) (key < currentNode.Key ? currentNode.Left : currentNode.Right);

            return currentNode;
        }

        public IAvlTree BstInsert(int key)
        {
            IAvlTree currentParent = null;
            var currentNode = this;

            while (currentNode != null)
            {
                currentParent = currentNode;
                currentNode = (AvlTree) (key <= currentNode.Key ? currentNode.Left : currentNode.Right);
            }

            currentNode = new AvlTree(key) {Parent = currentParent};

            if (key <= currentParent.Key)
                currentParent.Left = currentNode;
            else
                currentParent.Right = currentNode;

            return currentNode;
        }

        public IAvlTree BstDelete(IAvlTree tree)
        {
            if (tree.Left == null)
                return Transplant(tree, tree.Right);

            if (tree.Right == null)
                return Transplant(tree, tree.Right);

            var successor = tree.Right.Min();

            if (successor.Parent != tree)
            {
                Transplant(successor, successor.Right);
                successor.Right = tree.Right;
                successor.Right.Parent = successor;
            }

            Transplant(tree, successor);
            successor.Left = tree.Left;
            successor.Left.Parent = successor;
            return successor;
        }

        public IAvlTree Max()
        {
            var node = this;

            while (node.Right != null)
                node = (AvlTree) node.Right;

            return node;
        }

        public IAvlTree Min()
        {
            var node = this;

            while (node.Left != null)
                node = (AvlTree) node.Left;

            return node;
        }

        public IAvlTree Successor(IAvlTree tree)
        {
            if (tree.Right != null)
                return tree.Right.Min();

            var currentParent = tree.Parent;

            while (currentParent != null && tree == currentParent.Right)
            {
                tree = currentParent;
                currentParent = currentParent.Parent;
            }

            return currentParent;
        }

        public int Height(IAvlTree tree)
        {
            if (tree == null) return 0;
            if (tree.IsExternal) return 0;
            var height = 0;

            if (tree.HasLeft)
                height = height > Height(tree.Left) ? height : Height(tree.Left);
            if (tree.HasRight)
                height = height > Height(tree.Right) ? height : Height(tree.Right);

            return height + 1;
        }

        private static IAvlTree Transplant(IAvlTree originalBst, IAvlTree replacementBst)
        {
            if (originalBst == originalBst.Parent.Left)
                originalBst.Parent.Left = replacementBst;
            else
                originalBst.Parent.Right = replacementBst;

            if (replacementBst != null)
                replacementBst.Parent = originalBst.Parent;

            return replacementBst;
        }

        public int Count()
        {
            var queue = new Queue<IAvlTree>();
            queue.Enqueue(this);
            var count = 0;

            while (queue.Any())
            {
                var currentTree = queue.Dequeue();

                if (currentTree.HasLeft)
                    queue.Enqueue(currentTree.Left);

                if (currentTree.HasRight)
                    queue.Enqueue(currentTree.Right);

                count++;
            }

            return count;
        }

        public IAvlTree RightRotate()
        {
            var parent = Parent;
            Parent = Left;

            if (parent != null)
            {
                Parent.Parent = parent;
                Parent.Parent.Left = Parent;
            }

            Left = null;
            Parent.Right = this;
            return this;
        }

        public IAvlTree LeftRotate()
        {
            // save current key
            var currentKey = Key;

            // save new key
            var newKey = Right.Key;

            // save new left item
            var newLeft = Right;

            // save new right item
            var newRight = Right.Right;

            // set parents for new left and right
            newLeft.Parent = this;
            newRight.Parent = this;

            // set new keys
            Key = newKey;
            newLeft.Key = currentKey;

            Right = newRight;
            Left = newLeft;

            return this;
        }

        public IAvlTree RightLeftRotate()
        {
            Right = Right.RightRotate().Parent;
            return LeftRotate().Parent;
        }

        public IAvlTree LeftRightRotate()
        {
            Left = Left.LeftRotate().Parent;
            return RightRotate();
        }

        public IAvlTree AvlInsert(int key)
        {
            var insert = BstInsert(key);
            var parent = insert.Parent;

            while (parent != null && parent.Balance <= 1)
                parent = parent.Parent;

            if (parent != null && parent.Balance > 1)
                parent.LeftRotate();

            return this;
        }

        public void AvlDelete(int key)
        {
            throw new NotImplementedException();
        }

        public void PrintLevelOrder(IAvlTree tree)
        {
            var queue = new Queue<IAvlTree>();
            queue.Enqueue(tree);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                Console.Write(current.Key + " ");
                if (current.HasLeft) queue.Enqueue(current.Left);
                if (current.HasRight) queue.Enqueue(current.Right);
            }
        }
    }
}