using FluentAssertions;
using NUnit.Framework;
using Trees.ArithmeticTree.Implementation;

namespace Trees.ArithmeticTree.Tests.Tests
{
    [TestFixture]
    public class PostfixEvaluatorTests
    {
        [Test]
        public void EvaluatorTest()
        {
            PostfixEvaluator.Evaluate(2, 3, '+').Should().Be(5);
            PostfixEvaluator.Evaluate(2, 3, '^').Should().Be(8);
            PostfixEvaluator.Evaluate(10, -3, '*').Should().Be(-30);
            PostfixEvaluator.Evaluate(10, 5, '/').Should().Be(2);
        }

        [Test]
        public void PostfixEvaluatorTest()
        {
            // 3 + 4 * 5 = 23
            var queue = ShuntingYardAlgorithm.ShuntingYard("3+4*5");
            PostfixEvaluator.EvaluatePostfix(queue).Should().Be(23);

            // 3 * (4 + 5) = 27
            queue = ShuntingYardAlgorithm.ShuntingYard("3*(4+5)");
            PostfixEvaluator.EvaluatePostfix(queue).Should().Be(27);
        }
    }
}