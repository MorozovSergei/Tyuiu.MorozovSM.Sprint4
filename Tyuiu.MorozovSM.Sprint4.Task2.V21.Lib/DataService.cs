using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MorozovSM.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            foreach (int i in array)
            {
                if (i % 2 == 0) product *= i;
            }
            return product;
        }
    }
}
