using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint1.Task6.V7.Lib;

namespace Tyuiu.PyanzinaMA.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет как дела";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strTest);
            string wait = "Приве ка дел";
            Assert.AreEqual(wait, res);
        }
    }
}
