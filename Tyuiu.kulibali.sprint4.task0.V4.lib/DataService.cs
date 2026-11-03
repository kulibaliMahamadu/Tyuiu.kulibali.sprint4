namespace Tyuiu.kulibali.sprint4.task0.V4.lib
{
    using tyuiu.cources.programming.interfaces.Sprint4;
    public class DataService : ISprint4Task0V4
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int count = 1;

            

            foreach (int i in array)
            {
                if(i % 2 == 0)
                {

                    count *= i;

                }

               
            }
            return count;
            
            
        }
    }
}
