using Tyuiu.MorozovSM.Sprint4.Task5.V24.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        Random random = new Random();
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = { { 6, 5, 6, 7, 3 }, { 5, 4, 6, 7, 3 }, { 5, 5, 5, 6, 5 }, { 6, 5, 4, 4, 3 }, { 4, 5, 4, 5, 5 } };
            int wait = 25;
            Assert.AreEqual(ds.Calculate(array), wait);
        }
    }
}