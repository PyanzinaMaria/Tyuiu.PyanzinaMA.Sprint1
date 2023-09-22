using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint1.Task2.V22.Lib;

namespace Tyuiu.PyanzinaMA.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 4;
            int z = 12;

            var res = ds.CalculateAVGValue(x, y, z);
            Assert.AreEqual(6, res);
        }
    }
}
