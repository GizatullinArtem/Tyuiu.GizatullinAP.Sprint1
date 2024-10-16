using Tyuiu.GizatullinAP.Sprint1.Task7.V16.Lib;
namespace Tyuiu.GizatullinAP.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 1.022;
            Assert.AreEqual(wait, ds.Calculate(x));

        }
    }
}