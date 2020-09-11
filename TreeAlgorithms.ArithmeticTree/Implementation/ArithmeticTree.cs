using System;
using System.Collections.Generic;
using TreeAlgorithms.BinaryTree.Implementations;
using TreeAlgorithms.BinaryTree.Interfaces;

namespace TreeAlgorithms.ArithmeticTree.Implementation
{
    public static class ArithmeticTree
    {
        public static IBinaryTree<char> BuildArithmeticTree(string postfix)
        {
            var stack = new Stack<IBinaryTree<char>>();

            foreach (var input in postfix)
            {
                if (char.IsDigit(input))
                {
                    var tree = new BinaryTree<char>(input);
                    stack.Push(tree);
                }
                
                else if (!char.IsDigit(input))
                {
                    var tree1 = stack.Pop();
                    var tree2 = stack.Pop();
                    var tree = new BinaryTree<char>(input);
                    tree.AddLeft(tree2);
                    tree.AddRight(tree1);
                    stack.Push(tree);
                }
            }

            return stack.Pop();
        }

        public static void PrintInfixExpression(IBinaryTree<char> tree)
        {
            if (tree.HasLeft)
            {
                Console.Write("( ");
                PrintInfixExpression(tree.Left);
            }

            Console.Write(tree.Data + " ");

            if (tree.HasRight)
            {
                PrintInfixExpression(tree.Right);
                Console.Write(" )");
            }
        }
    }
}