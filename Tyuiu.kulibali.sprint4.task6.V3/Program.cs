using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kulibali.sprint4.task6.V3.lib;

namespace Tyuiu.kulibali.sprint4.task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
            Console.WriteLine("*****************************************************************************");

            string[] array = new string[] {" Январь" ," Февраль" , "Март" , "Апрель" , "Май" , "Июнь" , "Июль" ,
            "Август" , "Сентябрь" ,"Октябрь" , " Ноябрь" , "Декабрь" };

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }

            int res = ds.Calculate(array);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("****************************************************************************");

            int nums =  ds .Calculate(array);
            Console.WriteLine(nums);
            
            Console.ReadKey();
        }
    }
}
