using Tyuiu.GizatullinAP.Sprint1.Task2.V5.Lib;
namespace Tyuiu.GizatullinAP.Sprint1.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 2;
            var res = ds.CalculateSideSquare(a);
            Assert.AreEqual(12, res);

        }
    }
}