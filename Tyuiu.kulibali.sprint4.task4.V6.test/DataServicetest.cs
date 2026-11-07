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

            int[,] matrix = new int[5, 5] { { 7, 6, 6, 6, 9 },
                                            {4,4,4,9,4 },
                                            {5,5,5,6,5},
                                            {4,9,5,9,7 },
                                            {6,9,5,6,7 } };

            int[,]res = ds .Calculate(matrix);

            int[,] wait = new int[5, 5] { {0,6,6,6,0 } ,
                                          {4,4,4,0,4 },
                                          {0,0,0,6,0 },
                                          {4,0,0,0,0 },
                                          {6,0,0,6,0 } };

         for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(0 ,res[i,j]%2 );

                }
            }
            
            

        }
    }
}
