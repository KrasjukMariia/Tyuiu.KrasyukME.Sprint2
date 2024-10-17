using Tyuiu.KrasyukME.Sprint2.Task0.V27.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task0.V27
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
            Console.WriteLine("*                              Задание #0                                 *");
            Console.WriteLine("*                              Вариант #27                                 *");
            Console.WriteLine("* Выполнил: Красюк Мария Евгеньевна    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");

            int x, y;
            x = 1305;
            y = 275;


            Console.WriteLine(ds.GetCompareOperations(x, y));
            Console.ReadLine();
        }
    }
}
