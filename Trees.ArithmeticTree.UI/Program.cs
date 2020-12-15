using System;
using Trees.ShuntingYard.Implementation;

namespace Trees.ArithmeticTree.UI
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
            var arithmeticTree = Trees.ArithmeticTree.Implementation.ExpressionTree.BuildArithmeticTree(postfix);
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
            Trees.ArithmeticTree.Implementation.ExpressionTree.PrintInfixExpression(arithmeticTree);
        }
    }
}