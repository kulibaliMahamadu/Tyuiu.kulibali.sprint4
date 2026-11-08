using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kulibali.sprint4.task5.V8.lib;
namespace Tyuiu.kulibali.sprint4.task5.V8.test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { {-2,3,2,-1,4 },
                                           {1,3,-3,2,-2 },
                                           {2,3,-1,1,4 },
                                           {1,3,-3,1,1 },
                                           {2,-2,1,1,-3 } };
            int[,] res = ds.Calculate(matrix);

            int[,] wait = new int[5, 5] { {0,3,2,0,4 } ,
                                           {1,3,0,2,0 },
                                           {2,3,0,1,4 },
                                           {1,3,0,1,1 },
                                           {2,0,1,1,0 } };

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(5, matrix.GetLength(0));
                    Assert.AreEqual(5 , matrix.GetLength(1));
                }
            }

        }
    }
}
