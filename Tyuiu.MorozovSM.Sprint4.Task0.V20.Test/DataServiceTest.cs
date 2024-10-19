using Tyuiu.MorozovSM.Sprint4.Task0.V20.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[10] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int wait = 24576;
            Assert.AreEqual(ds.GetMultEvenArrEl(array), wait);
        }
    }
}