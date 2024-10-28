using Tyuiu.MolchankinaAP.Sprint3.Task6.V8.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;
            Assert.AreEqual(292, ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}