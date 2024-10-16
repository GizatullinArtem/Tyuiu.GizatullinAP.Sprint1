using Tyuiu.GizatullinAP.Sprint1.Task5.V2.Lib;

namespace Tyuiu.GizatullinAP.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()

        {DataService ds = new DataService();
            double temp = 32;
            var wait = 0;
            Assert.AreEqual(wait, ds.FahrenheitTo—elsius(temp));
        } 
    }
}