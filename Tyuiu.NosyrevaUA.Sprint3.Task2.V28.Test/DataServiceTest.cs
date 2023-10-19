using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint3.Task2.V28.Lib;

namespace Tyuiu.NosyrevaUA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(1, 9);
            Assert.AreEqual(res, -15.642);
        }
    }
}
