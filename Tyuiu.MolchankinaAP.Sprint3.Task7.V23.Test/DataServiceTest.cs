using Tyuiu.MolchankinaAP.Sprint3.Task7.V23.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService(); int startValue = -5;
            int stopValue = 5;

            double[] expectedValues = new double[] { -2.5, -1.125, -0.083, 0.625, 2, 3, 0, -0.875, -1.917, -2.875, -3.75 };
            double[] actualValues = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(expectedValues, actualValues, 3);
        }
    }
}