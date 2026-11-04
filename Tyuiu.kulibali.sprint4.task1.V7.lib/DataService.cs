using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.kulibali.sprint4.task1.V7.lib
{
    public class DataService : ISprint4Task1V7
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            foreach(int i in array)
            {
                if (i % 2 == 0)
                {
                    sumArray += i;
                }
            }
            return sumArray;

          
            
                
               
                    
              
            
            
            
            
                
                
                    
                
            
            
            
               
                
                    
                
            
            
        }
    }
}
