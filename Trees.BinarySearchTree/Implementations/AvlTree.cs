﻿using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Implementations
{
    public partial class BinarySearchTree
    {
        public IBinarySearchTree AvlInsert(int key)
        {
            var insertNode = BstInsert(key);
            var balance = insertNode.GetRoot().Balance;
            return balance > 1 ? insertNode.Parent.AvlLeftRotate() : insertNode;
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
            var parent = tree.Parent;
            tree.AvlLeftRotate();
            return parent.AvlRightRotate();
        }

        public IBinarySearchTree AvlLeftRightRotate()
        {
            return AvlLeftRightRotate(this);
        }

        public IBinarySearchTree AvlRightLeftRotate(IBinarySearchTree tree)
        {
            var parent = tree.Parent;
            tree.AvlRightRotate();
            return parent.AvlLeftRotate();
        }

        public IBinarySearchTree AvlRightLeftRotate()
        {
            return AvlRightLeftRotate(this);
        }
    }
}