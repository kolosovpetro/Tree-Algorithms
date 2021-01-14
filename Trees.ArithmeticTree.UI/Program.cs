using System;
using Trees.ArithmeticTree.Implementation;

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
            arithmeticTree.InOrderTraversal(arithmeticTree.Root);
            Console.WriteLine();
            Console.WriteLine("Postfix notation by Post-Order traversal: ");
            arithmeticTree.PostOrderTraversal(arithmeticTree.Root);
            Console.WriteLine();
            Console.WriteLine("Prefix notation by Pre-Order traversal: ");
            arithmeticTree.PreOrderTraversal(arithmeticTree.Root);
            Console.WriteLine();
            Console.WriteLine("Infix: ");
            ExpressionTree.PrintInfixExpression(arithmeticTree);
        }
    }
}