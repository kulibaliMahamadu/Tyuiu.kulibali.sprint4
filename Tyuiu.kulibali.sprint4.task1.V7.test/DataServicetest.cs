using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kulibali.sprint4.task1.V7.lib;
namespace Tyuiu.kulibali.sprint4.task1.V7.test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] Array = { 2, 5, 3, 8, 2, 6, 2, 5, 5,7, 4 };

            int res = ds.Calculate(Array);

            int wait = 24;

            Assert.AreEqual(wait ,res);

        }
    }
}
