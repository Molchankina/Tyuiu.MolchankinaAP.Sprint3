using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MolchankinaAP.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            for (int k = stopValue; k >= startValue; k--) // Цикл от stopValue до startValue
            {
                p *= Math.Pow(2, k) / (k + 1); // Правильное вычисление элемента ряда
            }
            return p * Math.Cos(1.8);

        }
    }
}
