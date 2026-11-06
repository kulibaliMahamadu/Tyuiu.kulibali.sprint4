using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kulibali.sprint4.task3.V19.lib;
namespace Tyuiu.kulibali.sprint4.task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                            *");
            Console.WriteLine("*******************************************************************************");

            int[,] arr = new int[5, 5] { { 6,5,6,3,8},
                                       {9,4,4,3,4 },
                                       {3,3,6,8,6 },
                                       {6,5,3,4,3 },
                                       {9,3,5,3,7 }  };

            int res = ds.Calculate(arr);

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                            *");
            Console.WriteLine("************************************************************************");



            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
