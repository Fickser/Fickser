using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnglesInTime;

namespace AnglesInTimeTest
{
    [TestClass]
    public class AnglesInTimeTest
    {
        [TestMethod]
        public void ThreePMExpect90Degrees()
        {
            //Arrange
            ITimeAngles TimeAngles = new TimeAngles(); 
            float expectedAngle = 90;

            //Act
            float ActualAngle = TimeAngles.TimeAngle(2013, 12, 18, 3, 00, 00);
            
            //Assert
            Assert.AreEqual(expectedAngle, ActualAngle);
        }

        [TestMethod]
        public void SixPMExpect180Degrees()
        {
            //Arrange
            ITimeAngles TimeAngles = new TimeAngles();
            float expectedAngle = 180;

            //Act
            float ActualAngle = TimeAngles.TimeAngle(2013, 12, 18, 6, 00, 00);

            //Assert
            Assert.AreEqual(expectedAngle, ActualAngle);
        }

        [TestMethod]
        public void NinePMExpect90Degrees()
        {
            //Arrange
            ITimeAngles TimeAngles = new TimeAngles();
            float expectedAngle = 90;

            //Act
            float ActualAngle = TimeAngles.TimeAngle(2013, 12, 18, 9, 00, 00);

            //Assert
            Assert.AreEqual(expectedAngle, ActualAngle);
        }

        [TestMethod]
        public void ThreeThirtyPMExpect105Degrees()
        {
            //Arrange
            ITimeAngles TimeAngles = new TimeAngles();
            float expectedAngle = 105;

            //Act
            float ActualAngle = TimeAngles.TimeAngle(2013, 12, 18, 3, 30, 00);

            //Assert
            Assert.AreEqual(expectedAngle, ActualAngle);
        }

        [TestMethod]
        public void ThreeFortyFivePMExpect157Point5Degrees()
        {
            //Arrange
            ITimeAngles TimeAngles = new TimeAngles();
            float expectedAngle = 157.5f;

            //Act
            float ActualAngle = TimeAngles.TimeAngle(2013, 12, 18, 3, 45, 00);

            //Assert
            Assert.AreEqual(expectedAngle, ActualAngle);
        }
    }
}
