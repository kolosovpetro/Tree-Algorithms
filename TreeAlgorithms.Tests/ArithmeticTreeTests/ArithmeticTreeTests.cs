using FluentAssertions;
using NUnit.Framework;
using TreeAlgorithms.ShuntingYardAlgorithm.Implementation;

namespace TreeAlgorithms.Tests.ArithmeticTreeTests
{
    [TestFixture]
    public class ArithmeticTreeTests
    {
        [Test]
        public void Tree_Test()
        {
            var initialEquation = "3+2*4/5";
            var checkPostfix = ShuntingYardMethod.PostfixString(initialEquation);
            checkPostfix.Should().Be("324*5/+");
            var arithmeticTree = ArithmeticTree.Implementation.ArithmeticTree.BuildArithmeticTree(checkPostfix);
            arithmeticTree.Root.Data.Should().Be('+');
        }
    }
}