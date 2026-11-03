namespace Tyuiu.kulibali.sprint4.task0.V4.test
{
    using Tyuiu.kulibali.sprint4.task0.V4.lib;
    public class DataServicetest
    {
        [Fact]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 7, 1, 3, 9, 8, 7, 9, 4 };
             int res =  ds .GetMultEvenArrEl(numsArray);
            int wait = 32;

            Assert.Equal(32  , res);
        }
    }
}
