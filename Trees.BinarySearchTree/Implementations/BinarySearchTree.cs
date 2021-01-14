using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Implementations
{
    public partial class BinarySearchTree : IBinarySearchTree, IBstInOrderEnumerable, IBstPostOrderEnumerable,
        IBstPreOrderEnumerable, IBstBreadthFirstEnumerable
    {
        public int Key { get; }
        public int Balance => CalculateBalance(this);
        public IBinarySearchTree Parent { get; set; }
        public IBinarySearchTree Left { get; set; }
        public IBinarySearchTree Right { get; set; }
        public int Count { get; private set; }
        public int Height => GetHeight(this);
        public bool IsEmpty => !HasLeft && !HasRight;
        public bool HasLeft => Left != null;
        public bool HasRight => Right != null;

        public BinarySearchTree(int key)
        {
            Key = key;
            Count = 1;
        }

        public IBinarySearchTree GetRoot()
        {
            var current = Parent;

            while (current.Parent != null)
            {
                current = current.Parent;
            }

            return current;
        }

        public IBinarySearchTree Search(int key)
        {
            IBinarySearchTree currentNode = this;

            while (currentNode != null && currentNode.Key != key)
                currentNode = key < currentNode.Key
                    ? currentNode.Left
                    : currentNode.Right;

            return currentNode;
        }

        public IBinarySearchTree BstInsert(int key)
        {
            IBinarySearchTree currentParent = null;
            IBinarySearchTree currentNode = this;

            while (currentNode != null)
            {
                currentParent = currentNode;
                currentNode = key <= currentNode.Key
                    ? currentNode.Left
                    : currentNode.Right;
            }

            currentNode = new BinarySearchTree(key) {Parent = currentParent};

            if (key <= currentParent.Key)
            {
                currentParent.Left = currentNode;
            }
            else
            {
                currentParent.Right = currentNode;
            }

            Count++;
            return currentNode;
        }

        public IBinarySearchTree BstDelete(IBinarySearchTree binarySearchTree)
        {
            if (!binarySearchTree.HasLeft)
                return Transplant(binarySearchTree, binarySearchTree.Right);

            if (!binarySearchTree.HasRight)
                return Transplant(binarySearchTree, binarySearchTree.Left);

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
            IBinarySearchTree node = this;

            while (node.Right != null)
            {
                node = node.Right;
            }

            return node;
        }

        public IBinarySearchTree Min()
        {
            IBinarySearchTree node = this;

            while (node.Left != null)
            {
                node = node.Left;
            }

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

        public bool IsExternal(IBinarySearchTree tree)
        {
            return tree.IsEmpty;
        }

        private int GetHeight(IBinarySearchTree tree)
        {
            if (tree == null) return 0;
            if (IsExternal(tree)) return 0;
            var height = 0;

            if (tree.HasLeft)
                height = height > GetHeight(tree.Left) ? height : GetHeight(tree.Left);
            if (tree.HasRight)
                height = height > GetHeight(tree.Right) ? height : GetHeight(tree.Right);

            return height + 1;
        }
        
        private static IBinarySearchTree Transplant(IBinarySearchTree originalBst, IBinarySearchTree replacementBst)
        {
            if (originalBst == originalBst.Parent.Left)
            {
                originalBst.Parent.Left = replacementBst;
            }
            else
            {
                originalBst.Parent.Right = replacementBst;
            }

            if (replacementBst != null)
            {
                replacementBst.Parent = originalBst.Parent;
            }

            return replacementBst;
        }
        
        private static int CalculateBalance(IBinarySearchTree tree)
        {
            if (tree == null)
            {
                return 0;
            }

            if (tree.HasRight && tree.HasLeft)
            {
                return tree.Right.Height - tree.Left.Height;
            }

            if (tree.HasLeft)
            {
                return -tree.Height;
            }

            if (tree.HasRight)
            {
                return tree.Height;
            }

            return 0;
        }

        IBstEnumerator IBstInOrderEnumerable.GetEnumerator()
        {
            return new BstInOrderEnumerator(this);
        }

        IBstEnumerator IBstPostOrderEnumerable.GetEnumerator()
        {
            return new BstPostOrderEnumerator(this);
        }

        IBstEnumerator IBstPreOrderEnumerable.GetEnumerator()
        {
            return new BstPreOrderEnumerator(this);
        }

        IBstEnumerator IBstBreadthFirstEnumerable.GetEnumerator()
        {
            return new BstBreadthFirstEnumerator(this);
        }
    }
}