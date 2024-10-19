using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MorozovSM.Sprint4.Task1.V4.Lib
{
    public class DataService : ISprint4Task1V4
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            foreach (int i in array)
            {
                if (i % 2 != 0) product *= i;
            }
            return product;
        }
    }
}
