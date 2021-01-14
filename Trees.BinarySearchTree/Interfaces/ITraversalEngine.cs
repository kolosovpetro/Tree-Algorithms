using System.Collections.Generic;

namespace Trees.BinarySearchTree.Interfaces
{
    public interface ITraversalEngine
    {
        IEnumerable<IBinarySearchTree> InOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> PreOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> PostOrderTraversalIterative(IBinarySearchTree tree);
        IEnumerable<IBinarySearchTree> BreadthFirstTraversalIterative(IBinarySearchTree tree);
    }
}