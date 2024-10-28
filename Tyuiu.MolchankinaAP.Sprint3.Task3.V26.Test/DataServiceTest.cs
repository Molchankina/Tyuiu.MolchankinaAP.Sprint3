using Tyuiu.MolchankinaAP.Sprint3.Task3.V26.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string text = "have a nice time";
            char item = 't';
            int count = ds.GetCharCount(text, item);

            Assert.AreEqual(1, count);
        }
    }
}