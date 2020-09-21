using TreeAlgorithms.AvlTree.Interfaces;

namespace TreeAlgorithms.AvlTree.Rotations
{
    public static class AvlRotation
    {
        public static void LeftRotation(ref IAvlTree tree)
        {
            var newRoot = tree.Right;
            var newLeft = newRoot.Parent;
            newLeft.Right = null;
            tree = newRoot;
            tree.Left = newLeft;
            newLeft.Parent = tree;
        }
    }
}