using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.PyanzinaMA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double percent = 20.0;
            double timeDays = 30.0;
           
            var res = ds.IncomeAmount(percent, timeDays);
            Assert.AreEqual((2500 * percent * timeDays) / 365, res);
        }
    }
}
