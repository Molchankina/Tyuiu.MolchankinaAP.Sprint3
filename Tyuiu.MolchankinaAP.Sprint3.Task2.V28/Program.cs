using Tyuiu.MolchankinaAP.Sprint3.Task2.V28.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double result = ds.GetMultiplySeries(1, 9);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
