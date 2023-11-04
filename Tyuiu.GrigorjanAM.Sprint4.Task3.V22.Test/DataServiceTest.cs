using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint4.Task3.V22.Lib;

namespace Tyuiu.GrigorjanAM.Sprint4.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 0, -1, 4, 7, 15 },
                            { 9, 5, 3256, 7, 8 },
                            { 7, 4, 9, 4, 2145 },
                            { 4, 4, -7, 21545, 4 },
                            { 4, 6789, 8, -6, 7 } };
            int res = ds.Calculate(matrix);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}
