using Tyuiu.MolchankinaAP.Sprint3.Task0.V23.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            double value = 1.5;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadLine();
        }
    }
}
