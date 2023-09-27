using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.PyanzinaMA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
            int k = 13650964;
            int h = ds.Calculate(k);
            int wait = 9;
            Assert.AreEqual(wait, h);
            

        }
    }
}
