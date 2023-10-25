using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint3.Task7.V9.Lib;

namespace Tyuiu.NosyrevaUA.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;

            double[] valwait;
            valwait = new double[len];

            valwait[0] = -61.79;
            valwait[1] = 4.07;
            valwait[2] = 0.23;
            valwait[3] = 11.73;
            valwait[4] = -11.41;
            valwait[5] = -3.0;
            valwait[6] = 0.31;
            valwait[7] = 2.69;
            valwait[8] = 5.83;
            valwait[9] = 5.11;
            valwait[10] = 40.64;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(valwait, res);
        }
    }
}
