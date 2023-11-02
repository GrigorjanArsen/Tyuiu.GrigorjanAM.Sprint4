using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint4.Task2.V4.Lib;

namespace Tyuiu.GrigorjanAM.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 1, 3, 6, 7 };
            int sum = ds.Calculate(array);
            int wait = 11;
            Assert.AreEqual(wait, sum);
        }
    }
}
