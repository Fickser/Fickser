using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DasFrameWurks;

namespace DasFrameWurks.test //Arrange, Act, Assert
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void GivenNumbersDivisibleByThreeButNotFiveExpectFizz()
        {
            // Arrange
            List<int> StartingSequence = new List<int>() { 3, 6, 9 };
            List<string> ExpectedSequence = new List<string>() { "3Fizz", "6Fizz", "9Fizz" };
            IFizzBuzz FizzBuzz = new FizzBuzz();

            // Act
            List<string> ActualSequence = FizzBuzz.GetFizzBuzz(StartingSequence);

            //Assert
            CollectionAssert.AreEqual(ExpectedSequence, ActualSequence);
        }

        [TestMethod]
        public void GivenNumbersDivisibleByFiveButNotThreeExpectBuzz()
        {
            // Arrange
            List<int> StartingSequence = new List<int>() { 5, 10, 20 };
            List<string> ExpectedSequence = new List<string>() { "5Buzz", "10Buzz", "20Buzz" };
            IFizzBuzz FizzBuzz = new FizzBuzz();

            // Act
            List<string> ActualSequence = FizzBuzz.GetFizzBuzz(StartingSequence);

            //Assert
            CollectionAssert.AreEqual(ExpectedSequence, ActualSequence);

        }

        [TestMethod]
        public void GivenNumbersDivisibleByFiveAndThreeExpectFizzBuzz()
        {
            // Arrange
            List<int> StartingSequence = new List<int>() { 15, 30, 45 };
            List<string> ExpectedSequence = new List<string>() { "15FizzBuzz", "30FizzBuzz", "45FizzBuzz" };
            IFizzBuzz FizzBuzz = new FizzBuzz();

            // Act
            List<string> ActualSequence = FizzBuzz.GetFizzBuzz(StartingSequence);

            //Assert
            CollectionAssert.AreEqual(ExpectedSequence, ActualSequence);
        }

        [TestMethod]
        public void GivenNumbersNotDivisibleByFiveAndThreeExpectNumber()
        {
            // Arrange
            List<int> StartingSequence = new List<int>() { 7, 14, 22 };
            List<string> ExpectedSequence = new List<string>() { "7", "14", "22" };
            IFizzBuzz FizzBuzz = new FizzBuzz();

            // Act
            List<string> ActualSequence = FizzBuzz.GetFizzBuzz(StartingSequence);

            //Assert
            CollectionAssert.AreEqual(ExpectedSequence, ActualSequence);
        }

        [TestMethod]
        public void GivenTehGauntletExpectTehGauntlet()
        {
            // Arrange
            List<int> StartingSequence = new List<int>() { 3, 25, 107, 30 };
            List<string> ExpectedSequence = new List<string>() { "3Fizz", "25Buzz", "107", "30FizzBuzz" };
            IFizzBuzz FizzBuzz = new FizzBuzz();

            // Act
            List<string> ActualSequence = FizzBuzz.GetFizzBuzz(StartingSequence);

            //Assert
            CollectionAssert.AreEqual(ExpectedSequence, ActualSequence);
        }
    }
}
