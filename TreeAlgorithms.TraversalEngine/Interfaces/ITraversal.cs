using System.Collections.Generic;
using TreeAlgorithms.BinarySearchTree.Interfaces;

namespace TreeAlgorithms.TraversalEngine.Interfaces
{
    public interface ITraversal
    {
        IEnumerable<IBinarySearchTree> InOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> PreOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> PostOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> BreadthFirstTraversalIterative(IBinarySearchTree tree);
    }
}