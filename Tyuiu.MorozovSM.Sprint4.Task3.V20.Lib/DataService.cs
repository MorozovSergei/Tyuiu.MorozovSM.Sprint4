using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MorozovSM.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                if (min > array[i,0]) min = array[i, 0];
            }
            return min;
        }
    }
}
