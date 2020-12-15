using System;
using FluentAssertions;
using NUnit.Framework;
using Trees.ShuntingYard.Implementation;

namespace Trees.Tests.ShuntingYardTests
{
    [TestFixture]
    public class ShuntingYardTests
    {
        [Test]
        public void OperatorPrecedenceTest()
        {
            Operator.Precedence('^').Should().Be(4);
            Operator.Precedence('*').Should().Be(3);
            Operator.Precedence('/').Should().Be(3);
            Operator.Precedence('+').Should().Be(2);
            Operator.Precedence('-').Should().Be(2);
            Operator.Precedence('a').Should().Be(0);
        }

        [Test]
        public void OperatorAssociativityTest()
        {
            Operator.Associativity('^').Should().Be("Right");
            Operator.Associativity('*').Should().Be("Left");
            Operator.Associativity('/').Should().Be("Left");
            Operator.Associativity('+').Should().Be("Left");
            Operator.Associativity('-').Should().Be("Left");

            Action act = () => Operator.Associativity('a');
            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Char a is not an operator");
        }

        [Test]
        public void IsOperatorTest()
        {
            Operator.IsOperator('a').Should().BeFalse();
            Operator.IsOperator('(').Should().BeFalse();
            Operator.IsOperator(')').Should().BeFalse();
        }

        [Test]
        public void InfixToPostfixTest()
        {
            var queue = ShuntingYardMethod.ShuntingYard("3+2*4/5");
            queue.Dequeue().Should().Be('3');
            queue.Dequeue().Should().Be('2');
            queue.Dequeue().Should().Be('4');
            queue.Dequeue().Should().Be('*');
            queue.Dequeue().Should().Be('5');
            queue.Dequeue().Should().Be('/');
            queue.Dequeue().Should().Be('+');

            queue = ShuntingYardMethod.ShuntingYard("3+4*5");
            queue.Dequeue().Should().Be('3');
            queue.Dequeue().Should().Be('4');
            queue.Dequeue().Should().Be('5');
            queue.Dequeue().Should().Be('*');
            queue.Dequeue().Should().Be('+');

            queue = ShuntingYardMethod.ShuntingYard("3*(4+5)");
            queue.Dequeue().Should().Be('3');
            queue.Dequeue().Should().Be('4');
            queue.Dequeue().Should().Be('5');
            queue.Dequeue().Should().Be('+');
            queue.Dequeue().Should().Be('*');

            queue = ShuntingYardMethod.ShuntingYard("3+4*2/(1-5)^2^3");
            // 3 4 2 × 1 5 − 2 3 ^ ^ ÷ +
            queue.Dequeue().Should().Be('3');
            queue.Dequeue().Should().Be('4');
            queue.Dequeue().Should().Be('2');
            queue.Dequeue().Should().Be('*');
            queue.Dequeue().Should().Be('1');
            queue.Dequeue().Should().Be('5');
            queue.Dequeue().Should().Be('-');
            queue.Dequeue().Should().Be('2');
            queue.Dequeue().Should().Be('3');
            queue.Dequeue().Should().Be('^');
            queue.Dequeue().Should().Be('^');
            queue.Dequeue().Should().Be('/');
            queue.Dequeue().Should().Be('+');

            queue = ShuntingYardMethod.ShuntingYard("3-2+1");
            queue.Dequeue().Should().Be('3');
            queue.Dequeue().Should().Be('2');
            queue.Dequeue().Should().Be('-');
            queue.Dequeue().Should().Be('1');
            queue.Dequeue().Should().Be('+');
        }
    }
}