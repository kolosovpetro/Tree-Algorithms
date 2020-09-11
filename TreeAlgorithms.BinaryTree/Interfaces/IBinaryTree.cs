namespace TreeAlgorithms.BinaryTree.Interfaces
{
    public interface IBinaryTree<T>
    {
        /// <summary>
        /// Value of a node
        /// </summary>
        T Data { get; }

        /// <summary>
        /// Returns the root ao the tree
        /// </summary>
        IBinaryTree<T> Root { get; set; }

        /// <summary>
        /// Reference to right sub-tree
        /// </summary>
        IBinaryTree<T> Right { get; }

        /// <summary>
        /// Reference to left sub-tree
        /// </summary>
        IBinaryTree<T> Left { get; }

        /// <summary>
        /// Returns a parent of the current node
        /// </summary>
        IBinaryTree<T> Parent { get; set; }

        /// <summary>
        /// Adds left subtree
        /// </summary>
        void AddRight(IBinaryTree<T> right);

        /// <summary>
        /// Adds right subtree
        /// </summary>
        void AddLeft(IBinaryTree<T> left);

        /// <summary>
        /// Indicates whenever tree is empty
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Indicates whenever current tree has left sub-tree
        /// </summary>
        bool HasLeft { get; }

        /// <summary>
        /// Indicates whenever current tree has right sub-tree
        /// </summary>
        bool HasRight { get; }

        /// <summary>
        /// Checks whenever tree is internal (has children)
        /// </summary>
        bool IsInternal(IBinaryTree<T> binaryTree);

        /// <summary>
        /// Checks whenever tree is external
        /// </summary>
        bool IsExternal(IBinaryTree<T> binaryTree);

        /// <summary>
        /// Returns a depth of a node
        /// </summary>
        int Depth(IBinaryTree<T> binaryTree);

        /// <summary>
        /// Returns the height of a node
        /// </summary>
        int Height(IBinaryTree<T> binaryTree);

        /// <summary>
        /// Performs pre-order (NLR) traversal of a tree and prints data to console
        /// </summary>
        void PreOrderTraversal(IBinaryTree<T> binaryTree);

        /// <summary>
        /// Performs in-order (LNR) traversal of a tree and prints data to console
        /// </summary>
        void InOrderTraversal(IBinaryTree<T> binaryTree);

        /// <summary>
        /// Performs out-order (RNL) traversal of a tree and prints data to console
        /// </summary>
        void OutOrderTraversal(IBinaryTree<T> binaryTree);

        /// <summary>
        /// Performs post-order (LRN) traversal of a tree and prints data to console
        /// </summary>
        void PostOrderTraversal(IBinaryTree<T> binaryTree);

        /// <summary>
        /// Performs level-order traversal of a tree and prints data to console
        /// </summary>
        void BreadthFirstTreeTraversal(IBinaryTree<T> binaryTree);
    }
}