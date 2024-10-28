using Tyuiu.MolchankinaAP.Sprint3.Task5.V18.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;
            Assert.AreEqual(198.7592097933161, ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}