using Trees.BinarySearchTree.Interfaces;

namespace Trees.AVL.Interfaces
{
    public interface IAvlTree : IBinarySearchTree
    {
        IAvlTree AvlInsert(IAvlTree avlTree);
        IAvlTree LeftRotate();
    }
}