using System;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Implementations
{
    public partial class BinarySearchTree
    {
        public IBinarySearchTree AvlInsert(int key)
        {
            throw new NotImplementedException();
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

        public IBinarySearchTree AvlRightRotate()
        {
            return AvlRightRotate(this);
        }
        
        public IBinarySearchTree AvlRightRotate(IBinarySearchTree tree)
        {
            var nodeLeft = tree.Left;
            tree.Left = null;
            tree.Parent = nodeLeft;
            nodeLeft.Right = tree;
            nodeLeft.Parent = null;
            return tree;
        }

        public IBinarySearchTree AvlLeftRightRotate(IBinarySearchTree tree)
        {
            throw new NotImplementedException();
        }

        public IBinarySearchTree AvlRightLeftRotate(IBinarySearchTree binarySearchTree)
        {
            throw new NotImplementedException();
        }
    }
}