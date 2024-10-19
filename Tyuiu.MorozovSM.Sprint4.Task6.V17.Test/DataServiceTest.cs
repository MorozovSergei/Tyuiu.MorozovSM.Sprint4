using Tyuiu.MorozovSM.Sprint4.Task6.V17.Lib;

namespace Tyuiu.MorozovSM.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int wait = 2;
            Assert.AreEqual(ds.Calculate(array), wait);
        }
    }
}