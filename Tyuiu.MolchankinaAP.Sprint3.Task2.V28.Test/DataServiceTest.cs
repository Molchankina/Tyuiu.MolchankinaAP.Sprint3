using Tyuiu.MolchankinaAP.Sprint3.Task2.V28.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double expected = 0.2250160836594891;
            double actual = ds.GetMultiplySeries(1, 9);
            Assert.AreEqual(expected, actual, 0.00001); // Допустимая погрешность 0.00001
        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double expected = 0.5625;
            double actual = ds.GetMultiplySeries(1, 5);
            Assert.AreEqual(expected, actual, 0.00001);
        }
    }
}