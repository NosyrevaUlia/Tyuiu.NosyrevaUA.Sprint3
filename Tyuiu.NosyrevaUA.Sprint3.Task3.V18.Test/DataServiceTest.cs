using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint3.Task3.V18.Lib;

namespace Tyuiu.NosyrevaUA.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string str = "4n5nvf 56 bgy";
            char n = 'n';
            Assert.AreEqual(ds.ReplaceNumOnChar(str,n),"nnnnvf nn bgy");


        }
    }
}
