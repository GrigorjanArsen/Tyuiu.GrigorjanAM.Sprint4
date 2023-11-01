using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint4.Task1.V24.Lib;

namespace Tyuiu.GrigorjanAM.Sprint4.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsa = {1, 3, 5, 6, 7 };
            int res = ds.Calculate(numsa);
            int wait = 105;
            Assert.AreEqual(wait, res);
        }
    }
}
