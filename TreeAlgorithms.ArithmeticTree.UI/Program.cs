using System;
using TreeAlgorithms.ShuntingYardAlgorithm.Implementation;

namespace TreeAlgorithms.ArithmeticTree.UI
{
    public static class Program
    {
        private static void Main()
        {
            var infix = "3+2*4/5";
            Console.WriteLine($"Initial infix: {infix}");
            // 324*5/+
            var postfix = ShuntingYardMethod.PostfixString(infix);
            Console.WriteLine($"Postfix by Shunting-yard: {postfix}");
            var arithmeticTree = Implementation.ArithmeticTree.BuildArithmeticTree(postfix);
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
            Implementation.ArithmeticTree.PrintInfixExpression(arithmeticTree);
        }
    }
}