using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kulibali.sprint4.task1.V7.lib;
namespace Tyuiu.kulibali.sprint4.task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                              *");
            Console.WriteLine("********************************************************************************");

            int[] Array = { 2, 5, 3, 8, 2, 6, 2, 5, 5,4 };
            int res = ds.Calculate(Array);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }   }
