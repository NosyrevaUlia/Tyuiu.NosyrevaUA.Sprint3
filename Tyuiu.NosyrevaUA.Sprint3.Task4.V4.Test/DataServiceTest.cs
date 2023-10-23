using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint3.Task4.V4.Lib;

namespace Tyuiu.NosyrevaUA.Sprint3.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startval = -5;
            int stopval = 5;
            double res = ds.Calculate(startval, stopval);
            Assert.AreEqual(res, -35.317);
        }
    }
}
