using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint3.Task6.V17.Lib;

namespace Tyuiu.NosyrevaUA.Sprint3.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 10;
            int stop = 20;

            int res = ds.GetSumTheDivisors(start, stop);
            Assert.AreEqual(res, 43);
        }
    }
}
