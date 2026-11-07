using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kulibali.sprint4.task4.V6.lib;
namespace Tyuiu.kulibali.sprint4.task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                               *");
            Console.WriteLine("*********************************************************************************");

            int rows =5;

            
            rows = Convert.ToInt32(Console.ReadLine());
            int cols = 5;
            
            cols = Convert.ToInt32(Console.ReadLine());

            

            int[,] matrix = new int[1, 1];

            matrix [1,1]= Convert.ToInt32(Console.ReadLine());

            int[,] res = ds.Calculate(matrix);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                             *");
            Console.WriteLine("**************************************************************************");
            
            
            Console.WriteLine( res);
            Console.ReadKey();
           
        }
    }
}
