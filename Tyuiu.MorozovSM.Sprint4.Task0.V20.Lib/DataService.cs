using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MorozovSM.Sprint4.Task0.V20.Lib
{
    public class DataService : ISprint4Task0V20
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int product = 1;
            foreach (int i in array)
            {
                if (i%2==0) product *= i;
            }
            return product;
        }
    }
}
