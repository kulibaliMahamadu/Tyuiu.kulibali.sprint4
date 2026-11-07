using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kulibali.sprint4.task4.V6.lib;
namespace Tyuiu.kulibali.sprint4.task4.V6.test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { {7,6,6,6,9},
                                          {4,4,4,9,4 },
                                          {5,5,5,6,5 },
                                          {4,9,5,9,7 },
                                          {6,9,5,6,7 } };
            int res =ds .Calculate(matrix);

            int wait = 14;
            
            Assert.AreEqual(wait , res);

                                            
                                             
                                             
                                     

                                               
                                            
                                          
      
        }
    }
}
