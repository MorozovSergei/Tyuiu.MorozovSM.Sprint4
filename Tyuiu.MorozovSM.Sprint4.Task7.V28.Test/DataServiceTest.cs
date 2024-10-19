using Tyuiu.MorozovSM.Sprint4.Task7.V28.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5;
            int columns = 3;
            string str = "623351179845632";
            int wait = 4608;
            Assert.AreEqual(ds.Calculate(rows,columns,str), wait);
        }
    }
}