using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kulibali.sprint4.task2.V23.lib;
namespace Tyuiu.kulibali.sprint4.task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("*****************************************************************************");

            int[] Array = { 4, 5, 6, 7, 8, 5, 6, 7, 5, 7, 6, 7, 5, 4, 8 };
            int res = ds.Calculate(Array);

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
