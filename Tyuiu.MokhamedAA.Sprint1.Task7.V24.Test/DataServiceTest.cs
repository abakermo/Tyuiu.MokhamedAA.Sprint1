using Tyuiu.MokhamedAA.Sprint1.Task7.V24.Lib;
namespace Tyuiu.MokhamedAA.Sprint1.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 1;
            int y = 2;
            Assert.AreEqual(Math.Round(((1 + Math.Cos(Math.Sqrt(x + 1))) / (Math.Sin(15 * y - 4))), 3), ds.Calculate(x, y));
        }
    }
}