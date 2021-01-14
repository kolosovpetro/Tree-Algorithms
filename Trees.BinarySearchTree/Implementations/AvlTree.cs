using System;
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
                insertNode.Parent.AvlLeftRotate();
            }

            return insertNode;
        }

        public IBinarySearchTree AvlLeftRotate(IBinarySearchTree tree)
        {
            if (Math.Abs(tree.Balance) < 2 || tree.Right == null)
                return tree;
            
            var nodeRight = tree.Right;

            if (tree.Parent != null)
            {
                var nodeParent = tree.Parent;
                nodeRight.Parent = nodeParent;
                nodeParent.Right = nodeRight;
            }
            
            tree.Parent = nodeRight;
            tree.Right = null;
            nodeRight.Left = tree;
            return tree;
        }

        public IBinarySearchTree AvlLeftRotate()
        {
            return AvlLeftRotate(this);
        }

        public IBinarySearchTree AvlLeftRightRotate(IBinarySearchTree binarySearchTree)
        {
            throw new NotImplementedException();
        }

        public IBinarySearchTree AvlRightRotate(IBinarySearchTree binarySearchTree)
        {
            throw new NotImplementedException();
        }

        public IBinarySearchTree AvlRightLeftRotate(IBinarySearchTree binarySearchTree)
        {
            throw new NotImplementedException();
        }
    }
}