using System.Collections.Generic;
using System.Linq;
using TreeAlgorithms.BinarySearchTree.Interfaces;
using TreeAlgorithms.TraversalEngine.Interfaces;

namespace TreeAlgorithms.TraversalEngine.Implementations
{
    public class TraversalEngine : ITraversal
    {
        public IEnumerable<IBinarySearchTree> InOrderTraversalIterative(IBinarySearchTree tree)
        {
            var stack = new Stack<IBinarySearchTree>();
            var currentNode = tree;

            while (currentNode != null || stack.Count > 0)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }

                currentNode = stack.Pop();
                yield return currentNode;
                currentNode = currentNode.Right;
            }
        }

        public IEnumerable<IBinarySearchTree> PreOrderTraversalIterative(IBinarySearchTree tree)
        {
            var stack = new Stack<IBinarySearchTree>();
            stack.Push(tree);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                yield return currentNode;

                if (currentNode.HasRight)
                    stack.Push(currentNode.Right);

                if (currentNode.HasLeft)
                    stack.Push(currentNode.Left);
            }
        }

        public IEnumerable<IBinarySearchTree> PostOrderTraversalIterative(IBinarySearchTree tree)
        {
            var stack = new Stack<IBinarySearchTree>();
            var outStack = new Stack<IBinarySearchTree>();
            stack.Push(tree);

            while (stack.Any())
            {
                var currentNode = stack.Pop();
                outStack.Push(currentNode);

                if (currentNode.HasLeft)
                    stack.Push(currentNode.Left);

                if (currentNode.HasRight)
                    stack.Push(currentNode.Right);
            }

            while (outStack.Count > 0)
                yield return outStack.Pop();
        }

        public IEnumerable<IBinarySearchTree> BreadthFirstTraversalIterative(IBinarySearchTree tree)
        {
            var queue = new Queue<IBinarySearchTree>();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.HasLeft)
                    queue.Enqueue(current.Left);
                if (current.HasRight)
                    queue.Enqueue(current.Right);

                yield return current;
            }
        }
    }
}