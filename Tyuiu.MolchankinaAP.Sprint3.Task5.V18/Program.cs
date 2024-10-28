using Tyuiu.MolchankinaAP.Sprint3.Task5.V18.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task5.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dataService = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 3;
            int stopValue2 = 11;
            Console.WriteLine("Переменная X = " + x);

            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + dataService.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
