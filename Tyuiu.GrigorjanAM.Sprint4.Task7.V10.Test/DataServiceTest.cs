using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint4.Task7.V10.Lib;

namespace Tyuiu.GrigorjanAM.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 4;
            int[,] mx = new int[n, m];
            string str = "695847142536";
            int wait = 30;
            int res = ds.Calculate(n, m, str);
            Assert.AreEqual(res, wait);

        }
    }
}
