﻿using FluentAssertions;
using NUnit.Framework;
using Trees.ArithmeticTree.Implementation;

namespace Trees.Tests.ArithmeticTreeTests
{
    [TestFixture]
    public class ArithmeticTreeTests
    {
        [Test]
        public void Tree_Test()
        {
            var initialEquation = "3+2*4/5";
            var checkPostfix = ShuntingYardAlgorithm.PostfixString(initialEquation);
            checkPostfix.Should().Be("324*5/+");
            var arithmeticTree = ExpressionTree.BuildArithmeticTree(checkPostfix);
            arithmeticTree.Root.Data.Should().Be('+');
        }
    }
}