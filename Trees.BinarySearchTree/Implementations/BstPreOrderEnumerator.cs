using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Implementations
{
    public class BstPreOrderEnumerator : IBstEnumerator
    {
        public bool MoveNext() => _count < _treeEnumerable.Count();

        public void Reset() => _count = 0;

        public IBinarySearchTree Current => GetCurrent();

        object IEnumerator.Current => Current;

        public void Dispose() => GC.SuppressFinalize(this);

        private readonly IEnumerable<IBinarySearchTree> _treeEnumerable;
        private int _count;

        public BstPreOrderEnumerator(IBinarySearchTree tree) =>
            _treeEnumerable = new TraversalEngineEngine().PreOrderTraversalIterative(tree);

        private IBinarySearchTree GetCurrent()
        {
            var current = _treeEnumerable.ElementAt(_count);
            _count++;
            return current;
        }
    }
}