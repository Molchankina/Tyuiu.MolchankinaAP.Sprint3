using Tyuiu.MolchankinaAP.Sprint3.Task3.V26.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "have a nice time";
            char item = 'e';

            Console.WriteLine("Cтрока = " + value);
            Console.WriteLine("Искомый символ = " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetCharCount(value, item));
            Console.ReadKey();
        }
    }
}
