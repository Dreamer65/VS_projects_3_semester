using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_8_new_order_;

namespace lab_8_Tests
{
    [TestClass]
    public class Form1_tests
    {
        [TestMethod]
        public void ReminderFind_abc_XReterned()
        {
            //  Arrange
            Random rand = new Random();
            int expected = rand.Next(0, 105);
            int k = expected % 3;
            int m = expected % 5;
            int n = expected % 7;
            // Act
            int actual = Form1.ReminderFind(k, m, n);
            // Assert
            Assert.AreEqual(expected, actual, "k= {1}, m = {2}, n = {3}", k, m, n);
        }
    }
}
