using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MolchankinaAP.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] functionValues = new double[stopValue - startValue + 1];
            for (int i = 0; i <= stopValue - startValue; i++)
            {
                int x = startValue + i;
                functionValues[i] = CalculateFunction(x);
            }
            return functionValues;
        }

        private double CalculateFunction(int x)
        {
            if (x == 1)
            {
                return 0; // Возвращаем 0 при делении на ноль
            }
            else
            {
                return 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
            }
        }
    }
}
