using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MorozovSM.Sprint4.Task6.V17.Lib
{
    public class DataService : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        { 
            int count = array.Count(x => x.Length == 6);
            return count;
        }
    }
}
