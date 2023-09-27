using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint1.Task4.V24.Lib;

namespace Tyuiu.PyanzinaMA.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 9;
            
            var res = ds.Calculate(x, y);
            Assert.AreEqual(Math.Round(Math.Log(x * y) / (2 + Math.Sqrt(2 * Math.Pow(y, 2))), 3), res);
        }
    }
}
