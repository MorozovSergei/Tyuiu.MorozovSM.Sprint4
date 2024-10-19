using Tyuiu.MorozovSM.Sprint4.Task2.V21.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[15] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            int wait = 512;
            Assert.AreEqual(ds.Calculate(array), wait);
        }
    }
}