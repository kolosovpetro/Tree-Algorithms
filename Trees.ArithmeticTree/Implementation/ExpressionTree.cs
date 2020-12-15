using System;
using System.Collections.Generic;
using Trees.BinaryTree.Implementations;
using Trees.BinaryTree.Interfaces;

namespace Trees.ArithmeticTree.Implementation
{
    public static class ExpressionTree
    {
        public static IBinaryTree<char> BuildArithmeticTree(string postfix)
        {
            var stack = new Stack<IBinaryTree<char>>();

            foreach (var input in postfix)
            {
                var tree = new BinaryTree<char>(input);
                if (char.IsDigit(input))
                    stack.Push(tree);

                else
                {
                    var tree1 = stack.Pop();
                    var tree2 = stack.Pop();
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