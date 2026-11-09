using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kulibali.sprint4.task6.V3.lib;
namespace Tyuiu.kulibali.sprint4.task6.V3.test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Январь"  , " Февпаль" ,"Март" ,"Апрель" ,"Май" ,"Июнь" ,"Июль" ,
            "Август", "Сентябрь" ,"Октябрь" , "Ноябрь" , "Декабрь"};

            int res = ds.Calculate(array);

            int wait = 4;

            Assert.AreEqual(wait  , res);
            

            
        }
    }
}
