using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [DataRow("", 0)]
        public void WhenStringIsEmptyReturnZero(string input, int expected)
        {
            // arrange
            var calculator = new StringCalculator.Business.Calculator();

            // act
            var result = calculator.Add(input);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenStringHasOneNumberReturnTheNumber()
        {
            var input = "5";

            // arrange
            var calculator = new StringCalculator.Business.Calculator();

            // act
            var result = calculator.Add(input);

            //assert
            Assert.AreEqual(int.Parse(input), result);
        }

        [TestMethod]
        [DataRow("1,2", 3)]
        [DataRow("0,6,1", 7)]
        [DataRow("2,3,6,1", 12)]
        [DataRow("5,1,3,4,8", 21)]
        public void WhenStringHasMultipleNumbersSeperatedByCommaReturnTheSum(string input, int expected)
        {
            // arrange
            var calculator = new StringCalculator.Business.Calculator();

            // act
            var result = calculator.Add(input);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("1\n2,3", 6)]
        public void WhenStringHasMultipleNumbersWithNewLineReturnTheSum(string input, int expected)
        {
            // arrange
            var calculator = new Business.Calculator();

            // act
            var result = calculator.Add(input);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("//;\n1;2", 3)]
        [DataRow("//@\n7@1@3@6", 17)]
        public void WhenStringHasCustomSeperatorReturnTheSum(string input, int expected)
        {
            // arrange
            var calculator = new Business.Calculator();

            // act
            var result = calculator.Add(input);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("//;\n1;-2;-1", "negatives not allowed -2,-1")]
        [DataRow("//;\n5;6;-10;0", "negatives not allowed -10")]
        [DataRow("//#\n4#7#2#-1#-8", "negatives not allowed -1,-8")]
        public void WhenStringHasNegativeNumberThrowException(string input, string expected)
        {
            // arrange
            var calculator = new Business.Calculator();
            
            try
            {
                // act
                var result = calculator.Add(input);
            }
            catch (ArgumentException ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
