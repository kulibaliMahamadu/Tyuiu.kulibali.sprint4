using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.kulibali.sprint4.task3.V19.lib
{
    public class DataService : ISprint4Task3V19
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);

            int cols = array.GetLength(1);

            int count = 0;

            for (int i = 0;i< 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i,j] % 2 ==0)
                    {
                        count++;
                    }
                    

                   
                }
            } 
            return count;
        }
    }
}
