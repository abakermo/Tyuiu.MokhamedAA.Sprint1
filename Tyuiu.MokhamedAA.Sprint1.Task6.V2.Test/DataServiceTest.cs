using Tyuiu.MokhamedAA.Sprint1.Task6.V2.Lib;
namespace Tyuiu.MokhamedAA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string greet = "Hello, I'm Jeff";
            bool res = true;
            Assert.AreEqual(res, ds.CheckHello(greet));
        }
    }
}