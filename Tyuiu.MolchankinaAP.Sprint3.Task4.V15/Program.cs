using Tyuiu.MolchankinaAP.Sprint3.Task4.V15.Lib;
namespace Tyuiu.MolchankinaAP.Sprint3.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("y=((sin(x)+x)/x)+0.75,  -5 <= x <= 5");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(-5, 5));
            Console.ReadKey();
        }
    }
}
