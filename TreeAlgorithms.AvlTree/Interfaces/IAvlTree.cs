namespace TreeAlgorithms.AvlTree.Interfaces
{
    public interface IAvlTree
    {
        // bst functionality
        int Key { get; }
        bool IsExternal { get; }
        bool HasLeft { get; }
        bool HasRight { get; }
        int Balance { get; }
        IAvlTree Parent { get; set; }
        IAvlTree Left { get; set; }
        IAvlTree Right { get; set; }
        IAvlTree Search(int key);
        IAvlTree BstInsert(int key);
        IAvlTree BstDelete(IAvlTree tree);
        IAvlTree Max();
        IAvlTree Min();
        IAvlTree Successor(IAvlTree tree);
        int Height(IAvlTree tree);
        int Count();
        
        // avl functionality
        IAvlTree RightRotate();
        IAvlTree LeftRotate();
        IAvlTree RightLeftRotate();
        IAvlTree LeftRightRotate();
        IAvlTree AvlInsert(int key);
        void AvlDelete(int key);
    }
}