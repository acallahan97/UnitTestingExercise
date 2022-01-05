using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        private readonly object tests;

        [Theory]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();
            //Act
            var actual = test1.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var tests = new UnitTestMethods();
            //Act
            var actual = tests.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 4, 25)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();
            //Act
            var actual = test2.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
#pragma warning disable xUnit1001 // Fact methods cannot have parameters
        public void SmallerNumber(int a, int b)
#pragma warning restore xUnit1001 // Fact methods cannot have parameters
        {
            //Arrange
            var tested = new UnitTestMethods();
            //Act
            var actual = tested.SmallerNumber(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
#pragma warning disable xUnit1001 // Fact methods cannot have parameters
        public void BiggerNumber(int one, int two)
#pragma warning restore xUnit1001 // Fact methods cannot have parameters
        {
            //Arrange
            var test3 = new UnitTestMethods();
            //Act
            var actual = test3.BiggerNumber(one, two);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
