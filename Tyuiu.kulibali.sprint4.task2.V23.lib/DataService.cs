using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.kulibali.sprint4.task2.V23.lib
{
    public class DataService : ISprint4Task2V23
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach(int i in array)
            {
                if(i % 2  == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
