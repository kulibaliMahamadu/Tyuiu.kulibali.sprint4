using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.kulibali.sprint4.task6.V3.lib
{
    public class DataService : ISprint4Task6V3
    {
        public int Calculate(string[] array)
        {
            

           
            
                
                string[] mas = Array.FindAll(array ,a =>a.Length<6);
           
            
            return mas.Length;
        }
     
        
            
    }
}
