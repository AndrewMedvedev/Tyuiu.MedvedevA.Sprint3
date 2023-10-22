using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint3.Task3.V23.Lib;

namespace Tyuiu.MedvedevA.Sprint3.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int value = 1;
            int startValue = 1, stopValue = 6;
            double res = dataService.GetMultiplySeries(value, startValue, stopValue), wait = 914700.940;
            Assert.AreEqual(wait, res);
        }
    }
}
