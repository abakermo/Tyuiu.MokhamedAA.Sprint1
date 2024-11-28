using Tyuiu.MokhamedAA.Sprint1.Task4.V26.Lib;
namespace Tyuiu.MokhamedAA.Sprint1.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 9;
            Assert.AreEqual((Math.Atan(x) + y) / (Math.Exp(y + x)), ds.Calculate(x, y));
        }
    }
}