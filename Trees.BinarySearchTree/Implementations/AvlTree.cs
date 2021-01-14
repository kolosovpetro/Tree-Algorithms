using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Implementations
{
    public partial class BinarySearchTree
    {
        public IBinarySearchTree AvlInsert(int key)
        {
            var insertNode = BstInsert(key);
            var balance = insertNode.GetRoot().Balance;
            if (balance > 1)
            {
                AvlLeftRotate(insertNode.Parent);
            }

            return insertNode;
        }

        public IBinarySearchTree AvlLeftRotate(IBinarySearchTree binarySearchTree)
        {
            var parent = binarySearchTree.Parent;
            binarySearchTree.Parent = null;
            parent.Right = null;
            parent.Parent = binarySearchTree;
            binarySearchTree.Left = parent;
            return binarySearchTree;
        }

        public IBinarySearchTree AvlLeftRightRotate(IBinarySearchTree binarySearchTree)
        {
            throw new System.NotImplementedException();
        }

        public IBinarySearchTree AvlRightRotate(IBinarySearchTree binarySearchTree)
        {
            throw new System.NotImplementedException();
        }

        public IBinarySearchTree AvlRightLeftRotate(IBinarySearchTree binarySearchTree)
        {
            throw new System.NotImplementedException();
        }
    }
}