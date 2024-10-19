using Tyuiu.MorozovSM.Sprint4.Task4.V16.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = { { 6, 5, 6, 7, 3 }, { 5, 4, 6, 7, 3 }, { 5, 5, 5, 6, 5 }, { 6, 5, 4, 4, 3 }, { 4, 5, 4, 5, 5 } };
            int[,] wait  = { { 1, 5, 1, 7, 3 }, { 5, 1, 1, 7, 3 }, { 5, 5, 5, 1, 5 }, { 1, 5, 1, 1, 3 }, { 1, 5, 1, 5, 5 } };
            CollectionAssert.AreEqual(ds.Calculate(array), wait);
        }
    }
}