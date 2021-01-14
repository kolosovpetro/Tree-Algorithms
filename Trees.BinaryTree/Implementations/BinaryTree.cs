using Trees.BinaryTree.Interfaces;

namespace Trees.BinaryTree.Implementations
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        public T Data { get; }
        public IBinaryTree<T> Right { get; private set; }
        public IBinaryTree<T> Left { get; private set; }
        public IBinaryTree<T> Parent { get; set; }
        public bool IsEmpty => !HasLeft && !HasRight;
        public bool HasLeft => Left != null;
        public bool HasRight => Right != null;

        public BinaryTree(T data)
        {
            Data = data;
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

        public bool IsInternal(IBinaryTree<T> binaryTree)
        {
            return !binaryTree.IsEmpty;
        }

        public bool IsExternal(IBinaryTree<T> binaryTree)
        {
            return binaryTree.IsEmpty;
        }

        public int Depth(IBinaryTree<T> binaryTree)
        {
            if (binaryTree == this) return 0;
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
    }
}