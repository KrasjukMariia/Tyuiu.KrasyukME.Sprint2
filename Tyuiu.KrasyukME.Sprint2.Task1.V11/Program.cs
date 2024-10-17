using Tyuiu.KrasyukME.Sprint2.Task1.V11.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Красюк.М.Е. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #2                              *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("*                              Задание #1                                 *");
            Console.WriteLine("*                              Вариант #11                                *");
            Console.WriteLine("* Выполнил: Красюк Мария Евгеньевна    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");

            int a, b , c ,d;
            a = 145;
            b = 156;
            c = 142;
            d = 117;

            Console.WriteLine(ds.GetLogicOperations( a,  b,  c, d));

            Console.ReadLine();/// 
        }
    }
}
