using System.Runtime.InteropServices.Marshalling;
using Tyuiu.kulibali.sprint4.task0.V4.lib;

namespace Tyuiu.kulibali.sprint4.task0.V4
{
    public class program
    {
        private static void Main(string[] args)
        {
          DataService ds = new DataService();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                            *");
            Console.WriteLine("*******************************************************************************");

            int[] numsArray = { 1, 2, 3, 4, 5,  7,  9,  11,  13,  15 };
            int res = ds .GetMultEvenArrEl(numsArray);

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                                  *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
   

 
   
        
    
