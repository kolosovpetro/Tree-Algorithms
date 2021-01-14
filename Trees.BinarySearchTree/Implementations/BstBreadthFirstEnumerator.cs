using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Trees.BinarySearchTree.Interfaces;

namespace Trees.BinarySearchTree.Implementations
{
    public class BstBreadthFirstEnumerator : IBstEnumerator
    {
        private readonly IEnumerable<IBinarySearchTree> _treeEnumerable;
        private int _count;
        
        public IBinarySearchTree Current => GetCurrent();
        object IEnumerator.Current => Current;
        
        public bool MoveNext()
        {
            return _count < _treeEnumerable.Count();
        }

        public void Reset()
        {
            _count = 0;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        
        public BstBreadthFirstEnumerator(IBinarySearchTree tree)
        {
            _treeEnumerable = new TraversalEngineEngine().BreadthFirstTraversalIterative(tree);
        }

        private IBinarySearchTree GetCurrent()
        {
            var current = _treeEnumerable.ElementAt(_count);
            _count++;
            return current;
        }
    }
}