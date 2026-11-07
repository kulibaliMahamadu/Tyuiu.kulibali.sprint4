using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.kulibali.sprint4.task4.V6.lib
{
    public class DataService : ISprint4Task4V6
    {
        public int[,] Calculate(int[,] matrix)
        {
           int rows=matrix.GetLength(0);

            int cols=matrix.GetLength(1);

            

            for(int i = 0; i<5; i++)
            {
                for(int j = 0;j <5; j++)
                {
                    if(matrix[i,j] != 0)
                    {
                        matrix[i,j] = 0;
                        

                    }
                }
            }
            return matrix;
            
            
            
            
            
              
               
                    
                    

                        

                        
                        
                            
                        
                        
                        
                   
                
            
            
            
            
          
        }
     
    }
}
