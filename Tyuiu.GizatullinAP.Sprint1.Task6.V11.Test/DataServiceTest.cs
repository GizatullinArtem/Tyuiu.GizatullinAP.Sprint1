using Tyuiu.GizatullinAP.Sprint1.Task6.V11.Lib;

namespace Tyuiu.GizatullinAP.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            String str = "afkvmklfdvmlkfgdnba";
            Assert.AreEqual(true, ds.CheckeFirstLetterRepetition(str));
        }
    }
}