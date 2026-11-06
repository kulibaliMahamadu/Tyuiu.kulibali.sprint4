using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kulibali.sprint4.task3.V19.lib;

namespace Tyuiu.kulibali.sprint4.task3.V19.test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] arr = new int[5, 5] {  {6,5,5,3,8 },
                                          {9,4,4,3,4 },
                                          {3,3,6,8,6 },
                                          {6,5,3,4,3 },
                                          {9,3,5,3,7 }  };

            int res = ds.Calculate(arr);
            int wait = 10;
            Assert.AreEqual(wait , res);
        }
    }
}
