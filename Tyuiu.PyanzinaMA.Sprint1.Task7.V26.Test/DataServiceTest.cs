using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint1.Task7.V26.Lib;

namespace Tyuiu.PyanzinaMA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            var z = ds.Calculate(x, y);
            var wait = 0.754;
            Assert.AreEqual(wait, z);
        }
    }
}
