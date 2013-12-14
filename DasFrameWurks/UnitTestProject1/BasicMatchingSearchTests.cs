namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;

    using DasFrameWurks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The basic matching search tests.
    /// </summary>
    [TestClass]
    public class BasicMatchingSearchTests
    {
        #region Fields

        /// <summary>
        /// The hay stack.
        /// </summary>
        private readonly List<string> hayStack = new List<string> { "foo", "bar", "hello", "world" };

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The given null hay stack expect argument null exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullHayStackExpectArgumentNullException()
        {
            // arrange
            IBasicMatchingSearch searcher = new BasicMatchingSearch();

            // act
            searcher.Contains(null, "foo");
        }

        /// <summary>
        /// The given null string expect argument null exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullStringExpectArgumentNullException()
        {
            // Arrange
            IBasicMatchingSearch searcher = new BasicMatchingSearch();

            // Act
            searcher.Contains(this.hayStack, null);
        }

        /// <summary>
        /// The given string in hay stack expect true.
        /// </summary>
        [TestMethod]
        public void GivenStringInHayStackExpectTrue()
        {
            // arrange
            IBasicMatchingSearch searcher = new BasicMatchingSearch();

            // act
            bool actualResult = searcher.Contains(this.hayStack, this.hayStack[0]);

            // assert
            Assert.IsTrue(actualResult);
        }

        /// <summary>
        /// The given string not in hay stack expect false.
        /// </summary>
        [TestMethod]
        public void GivenStringNotInHayStackExpectFalse()
        {
            // arrange
            IBasicMatchingSearch searcher = new BasicMatchingSearch();
            string needle = "dude";

            // act
            bool actualResult = searcher.Contains(this.hayStack, needle);

            // assert
            Assert.IsFalse(actualResult);
        }

        #endregion
    }
}