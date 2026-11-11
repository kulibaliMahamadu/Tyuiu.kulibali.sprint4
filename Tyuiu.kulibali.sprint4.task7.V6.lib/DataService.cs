using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.kulibali.sprint4.task7.V6.lib
{
    public class DataService : ISprint4Task7V6
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;

            int[,] matrix = new int[n, m];


            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[i * m + j].ToString());

                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                  
                }
            }
            return sum;

          
            

               

                    
                    
                    
                    
                
            
            




























        }    
        
                         
                        
                          
                        
                    
            
          
           
            
         
            
                
                
                    
                    
                      
                    
                
                
            
           
               
                
                  
            
           
        }
    }
