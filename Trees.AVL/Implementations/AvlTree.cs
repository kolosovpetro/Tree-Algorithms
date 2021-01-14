using Trees.AVL.Interfaces;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.AVL.Implementations
{
    public class AvlTree : BinarySearchTree.Implementations.BinarySearchTree, IAvlTree
    {
        public AvlTree(int key) : base(key)
        {
        }

        public IAvlTree AvlInsert(IAvlTree avlTree)
        {
            throw new System.NotImplementedException();
        }

        public IAvlTree LeftRotate()
        {
            throw new System.NotImplementedException();
        }
    }
}