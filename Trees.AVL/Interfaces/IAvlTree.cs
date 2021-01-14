using Trees.BinarySearchTree.Interfaces;

namespace Trees.AVL.Interfaces
{
    public interface IAvlTree : IBinarySearchTree
    {
        int Balance { get; }
        IAvlTree AvlInsert(IAvlTree avlTree);
        IAvlTree LeftRotate();
    }
}