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
            var parent = tree.Parent;
            var right = tree.Right;
            tree.Right = null;
            right.Parent = parent;
            
            if (parent != null)
            {
                if (parent.Right == tree)
                {
                    parent.Right = right;
                }
                else
                {
                    parent.Left = right;
                }
            }

            right.Left = tree;
            tree.Parent = right;
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
            var parent = tree.Parent;
            var left = tree.Left;
            tree.Left = null;

            left.Parent = parent;
            if (parent != null)
            {
                if (parent.Left == tree)
                {
                    parent.Left = left;
                }
                else
                {
                    parent.Right = left;
                }
            }

            tree.Parent = left;
            left.Right = tree;
            return tree;
        }

        public IBinarySearchTree AvlLeftRightRotate(IBinarySearchTree tree)
        {
            var rotate = tree.AvlLeftRotate();
            return rotate.Parent.Parent.AvlRightRotate();
        }

        public IBinarySearchTree AvlLeftRightRotate()
        {
            return AvlLeftRightRotate(this);
        }

        public IBinarySearchTree AvlRightLeftRotate(IBinarySearchTree binarySearchTree)
        {
            throw new NotImplementedException();
        }
    }
}