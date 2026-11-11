using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Markup;
using Tyuiu.kulibali.sprint4.task7.V6.lib;
namespace Tyuiu.kulibali.sprint4.task7.V6.test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 3;

            int m = 4;

            string value = "458963214789";



            int matrix  = ds.Calculate (n, m, value);

            int wait = 34;
            Assert.AreEqual(wait , matrix);

            

        

          

         
           
            
          
                
                  
             
                
            

            
        }
    }
}
