using System;
using Trees.ArithmeticTree.Implementation;
using Trees.BinaryTree.Implementations;

namespace Trees.ArithmeticTree.UI
{
    public static class Program
    {
        private static void Main()
        {
            const string infix = "3+2*4/5";
            Console.WriteLine($"Initial infix: {infix}");
            // 324*5/+
            var postfix = ShuntingYardAlgorithm.PostfixString(infix);
            Console.WriteLine($"Postfix by Shunting-yard: {postfix}");
            var arithmeticTree = ExpressionTree.BuildArithmeticTree(postfix);
            Console.WriteLine("Infix by In-Order traversal: ");
            DisplayTree.InOrderTraversal(arithmeticTree);
            Console.WriteLine();
            Console.WriteLine("Postfix notation by Post-Order traversal: ");
            DisplayTree.PostOrderTraversal(arithmeticTree);
            Console.WriteLine();
            Console.WriteLine("Prefix notation by Pre-Order traversal: ");
            DisplayTree.PreOrderTraversal(arithmeticTree);
            Console.WriteLine();
            Console.WriteLine("Infix: ");
            ExpressionTree.PrintInfixExpression(arithmeticTree);
        }
    }
}