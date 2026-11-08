using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kulibali.sprint4.task5.V8.lib;
namespace Tyuiu.kulibali.sprint4.task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("********************************************************************");
            Console.Write("* ИСХОДНЫЕ ДАННЫЕ                                                  *");
            Console.Write("**********************************************************************");

            int rows = 5;

            rows = Convert.ToInt32(Console.ReadLine());


            int cols = 5;
            cols = Convert.ToInt32(Console.ReadLine());




            int[,] matrix = new int[rows, cols];

            
            
                                      
                                        

            

            int[,] res = ds.Calculate(matrix);
            
            Console.Write("*********************************************************************************");
            Console.Write("* РЕЗУЛЬТАТ                                                                    *");
            Console.Write("*********************************************************************************");

            Console.Write(res);
            Console.ReadKey();
        }
    }
}
