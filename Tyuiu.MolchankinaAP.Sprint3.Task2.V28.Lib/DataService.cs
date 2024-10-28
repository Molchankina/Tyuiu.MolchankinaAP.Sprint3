using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MolchankinaAP.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            int k = startValue;
            double multiplySeries = 1;
            double x = 1.8; // Используем фиксированное значение x
            do
            {
                multiplySeries *= Math.Pow(2, k) / (k + 1) * Math.Cos(x);
                k++;
            } while (k <= stopValue);
            return Math.Round(multiplySeries, 3);
        }
    }
}
