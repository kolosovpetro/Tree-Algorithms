#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TreeAlgorithms.BinarySearchTree.Enumerator.Interfaces;
using TreeAlgorithms.BinarySearchTree.Interfaces;

namespace TreeAlgorithms.BinarySearchTree.Enumerator.Enumerators
{
    public class BstInOrderEnumerator : IBstEnumerator
    {
        public bool MoveNext() => _count < _treeEnumerable.Count();

        public void Reset() => _count = 0;

        public IBinarySearchTree Current => GetCurrent();

        object IEnumerator.Current => Current;

        public void Dispose() => GC.SuppressFinalize(this);

        private readonly IEnumerable<IBinarySearchTree> _treeEnumerable;
        private int _count;

        public BstInOrderEnumerator(IBinarySearchTree tree) =>
            _treeEnumerable = new TraversalEngine.Implementations.TraversalEngine().InOrderTraversalIterative(tree);

        private IBinarySearchTree GetCurrent()
        {
            var current = _treeEnumerable.ElementAt(_count);
            _count++;
            return current;
        }
    }
}