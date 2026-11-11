using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kulibali.sprint4.task7.V6.lib;
namespace Tyuiu.kulibali.sprint4.task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("************************************************************************");
            Console.Write("* ИСХОДНЫЕ ДАННЫЕ                                                      *");
            Console.Write("*********************************************************************");

            string value = "25487965";


            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int m;
            m= Convert.ToInt32(Console.ReadLine()); 

            int matrix = ds .Calculate(n, m,value );

            Console.Write("ИСХОДНЫЕ ДАННЫЕ");

            Console.Write("**************************************************************");
            Console.Write("* РЕЗУЛЬТАТ                                                * ");
            Console.Write("************************************************************");

            Console.Write(matrix);

            Console.ReadKey();
            
        }
    }
}
