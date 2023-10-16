using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint3.Task0.V19.Lib;

namespace Tyuiu.NosyrevaUA.Sprint3.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int StopValue = 10;
            double res = ds.GetSumSeries(startValue, StopValue);
            Assert.AreEqual(res, 4.399);
        }
    }
}
