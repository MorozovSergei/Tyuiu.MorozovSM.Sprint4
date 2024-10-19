using Tyuiu.MorozovSM.Sprint4.Task1.V4.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[10] { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
            int wait = 2835;
            Assert.AreEqual(ds.Calculate(array), wait);
        }
    }
}