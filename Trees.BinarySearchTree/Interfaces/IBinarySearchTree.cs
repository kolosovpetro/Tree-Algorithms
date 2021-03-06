﻿namespace Trees.BinarySearchTree.Interfaces
{
    public interface IBinarySearchTree
    {
        // bst functionality
        int Key { get; }
        int Count { get; }
        int Height { get; }
        bool IsEmpty { get; }
        bool HasLeft { get; }
        bool HasRight { get; }
        int Balance { get; }
        IBinarySearchTree Parent { get; set; }
        IBinarySearchTree Left { get; set; }
        IBinarySearchTree Right { get; set; }
        IBinarySearchTree GetRoot();
        IBinarySearchTree Search(int key);
        IBinarySearchTree BstInsert(int key);
        IBinarySearchTree BstDelete(IBinarySearchTree binarySearchTree);
        IBinarySearchTree Max();
        IBinarySearchTree Min();
        IBinarySearchTree Successor(IBinarySearchTree binarySearchTree);
        bool IsExternal(IBinarySearchTree tree);

        // avl functionality
        IBinarySearchTree AvlInsert(int key);
        IBinarySearchTree AvlLeftRotate(IBinarySearchTree tree);
        IBinarySearchTree AvlLeftRotate();
        IBinarySearchTree AvlRightRotate(IBinarySearchTree tree);
        IBinarySearchTree AvlRightRotate();
        IBinarySearchTree AvlLeftRightRotate(IBinarySearchTree tree);
        IBinarySearchTree AvlLeftRightRotate();
        IBinarySearchTree AvlRightLeftRotate(IBinarySearchTree tree);
        IBinarySearchTree AvlRightLeftRotate();
    }
}