using Tyuiu.MolchankinaAP.Sprint3.Task1.V15.Lib;

namespace Tyuiu.MolchankinaAP.Sprint3.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 2;
            int start1 = 1;
            int finish2 = 5;
            var res = ds.GetMultiplySeries(value, start1, finish2);
            int wait = 208845;
            Assert.AreEqual(wait, res);
        }
    }
}