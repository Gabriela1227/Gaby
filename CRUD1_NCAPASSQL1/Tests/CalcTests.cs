using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingMsTestIntro;

namespace Tests
{
    [TestClass]
    public class CalcTests
    {
        [DataRow(4, 4, 8)]
        [DataRow(5, 5, 10)]
        [DataRow(24, 26, 50)]
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue(int a, int b, int expected)
        {
            //Arrange
           

            //Act
            int actual = Calcs.Sum(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
