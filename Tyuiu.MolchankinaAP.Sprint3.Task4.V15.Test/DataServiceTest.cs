using Tyuiu.MolchankinaAP.Sprint3.Task4.V15.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(-5, 5);
            Assert.AreEqual(res, 623.499);
        }
    }
}