using Tyuiu.GizatullinAP.Sprint1.Task4.V14.Lib;
namespace Tyuiu.GizatullinAP.Sprint1.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 6;
            double wait = 0.015;
            var r = ds.Calculate(x , y);
            Assert.AreEqual(wait, r);

        }
    }
}