using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace TreeAlgorithms.ShuntingYardAlgorithm.Implementation
{
    public static class PostfixEvaluator
    {
        public static double Evaluate(double value1, double value2, char @operator)
        {
            return @operator switch
            {
                '+' => value1 + value2,
                '-' => value1 - value2,
                '*' => value1 * value2,
                '/' => value1 / value2,
                '^' => Pow(value1, value2),
                _ => 0
            };
        }

        public static double EvaluatePostfix(Queue<char> postfix)
        {
            var evaluatorStack = new Stack<double>();
            while (postfix.Any())
            {
                var current = postfix.Dequeue();
                if (double.TryParse(current.ToString(), out var number))
                {
                    evaluatorStack.Push(number);
                    continue;
                }
                var val1 = evaluatorStack.Pop();
                var val2 = evaluatorStack.Pop();
                var output = Evaluate(val1, val2, current);
                evaluatorStack.Push(output);
            }

            return evaluatorStack.Pop();
        }
    }
}