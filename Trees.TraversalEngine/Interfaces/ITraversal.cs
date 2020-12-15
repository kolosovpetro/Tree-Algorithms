using System.Collections.Generic;
using Trees.BST.Interfaces;

namespace Trees.TraversalEngine.Interfaces
{
    public interface ITraversal
    {
        IEnumerable<IBinarySearchTree> InOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> PreOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> PostOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> BreadthFirstTraversalIterative(IBinarySearchTree tree);
    }
}