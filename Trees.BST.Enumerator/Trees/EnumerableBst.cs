using Trees.BST.Enumerator.Enumerators;
using Trees.BST.Enumerator.Interfaces;
using Trees.BST.Implementations;

namespace Trees.BST.Enumerator.Trees
{
    public class EnumerableBst : BinarySearchTree,
        IBstInOrderEnumerable, IBstPostOrderEnumerable, IBstPreOrderEnumerable, IBstDepthFirstEnumerable
    {
        public EnumerableBst(int key) : base(key)
        {
        }

        IBstEnumerator IBstInOrderEnumerable.GetEnumerator() => new BstInOrderEnumerator(this);

        IBstEnumerator IBstPostOrderEnumerable.GetEnumerator() => new BstPostOrderEnumerator(this);

        IBstEnumerator IBstPreOrderEnumerable.GetEnumerator() => new BstPreOrderEnumerator(this);

        IBstEnumerator IBstDepthFirstEnumerable.GetEnumerator() => new BstBreadthFirstIterator(this);
    }
}