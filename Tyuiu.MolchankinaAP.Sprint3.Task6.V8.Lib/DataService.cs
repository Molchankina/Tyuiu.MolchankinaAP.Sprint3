using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MolchankinaAP.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumOfDivisors = 0;
            for (int num = startValue; num <= stopValue; num++)
            {
                for (int divisor = 2; divisor < num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        sumOfDivisors += divisor;
                    }
                }
            }
            return sumOfDivisors;
        }
    }
}
