using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kulibali.sprint4.task2.V23.lib;
namespace Tyuiu.kulibali.sprint4.task2.V23.test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValiCalculate()
        {
            DataService ds = new DataService();

            int[] Array = {4,5,7,5,6,8,4,6,7,5,7,4,6,5,7};

            int res = ds.Calculate(Array);

            int wait = 38;

            Assert.AreEqual(wait, res);


        }
    }
}
