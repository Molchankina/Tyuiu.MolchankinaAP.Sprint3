using Tyuiu.MolchankinaAP.Sprint3.Task7.V23.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue, stopValue;

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("Введите начало отрезка: ");
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец отрезка: ");
            stopValue = Convert.ToInt32(Console.ReadLine());

            double[] valueArray = new double[ds.GetMassFunction(startValue, stopValue).Length];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("+---------+----------+");
            Console.WriteLine("|    X    |    f(x)  |");
            Console.WriteLine("+---------+----------+");

            for (int i = 0; i <= ds.GetMassFunction(startValue, stopValue).Length; i++)
            {
                Console.WriteLine("|{0,5:d}    |  {1,5:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();

        }
    }
}
