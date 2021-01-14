namespace Trees.BinaryTree.Interfaces
{
    public interface IBinaryTree<T>
    {
        T Data { get; }
        IBinaryTree<T> Right { get; }
        IBinaryTree<T> Left { get; }
        IBinaryTree<T> Parent { get; set; }
        void AddRight(IBinaryTree<T> right);
        void AddLeft(IBinaryTree<T> left);
        bool IsEmpty { get; }
        bool HasLeft { get; }
        bool HasRight { get; }
        bool IsInternal(IBinaryTree<T> binaryTree);
        bool IsExternal(IBinaryTree<T> binaryTree);
        int Depth(IBinaryTree<T> binaryTree);
        int Height(IBinaryTree<T> binaryTree);
    }
}