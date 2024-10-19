using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MorozovSM.Sprint4.Task7.V28.Lib
{
    public class DataService : ISprint4Task7V28
    {
        public int Calculate(int n, int m, string value)
        {
            int product = 1;
            int[,] array = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i,j] = Convert.ToInt32(value.Substring(i*m+j,1));
                }
            }
            for (int i = 0; i < array.GetLength(0); i++) for (int j = 0; j < array.GetLength(1); j++) if (array[i, j] % 2 == 0) product *= array[i, j];
            return product;
        }
    }
}
