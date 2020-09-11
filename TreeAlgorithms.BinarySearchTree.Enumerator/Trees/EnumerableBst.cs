using TreeAlgorithms.BinarySearchTree.Enumerator.Enumerators;
using TreeAlgorithms.BinarySearchTree.Enumerator.Interfaces;

namespace TreeAlgorithms.BinarySearchTree.Enumerator.Trees
{
    public class EnumerableBst : BinarySearchTree.Implementations.BinarySearchTree,
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