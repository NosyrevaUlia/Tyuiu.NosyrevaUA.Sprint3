using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint3.Task5.V22.Lib;

namespace Tyuiu.NosyrevaUA.Sprint3.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 12;
            double res = ds.GetSumSumSeries(x, start1, start2, stop1, stop2);
            Assert.AreEqual(res, 68.991);
        }
    }
}
