using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ItUniver.TeleCalc.Core;

namespace ItUniver.TeleCalc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {

            //Arrange
            var calc = new Calc();
            var x = 1;
            var y = 2;
            
            //Act
            var result1 = calc.Sum(x, y);
            var result2 = calc.Sum(10, 0);
            var result3 = calc.Div(5, 2);
            var result4 = calc.Cube(2);
            var result5 = calc.Mult(x, y);
            var result6 = calc.Sub(6, 2);

            //Assert
            Assert.AreEqual(3, result1);
            Assert.AreEqual(10, result2);
            Assert.AreEqual(2.5, result3);
            Assert.AreEqual(8, result4);
            Assert.AreEqual(2, result5);
            Assert.AreEqual(4, result6);

        }
    }
}
