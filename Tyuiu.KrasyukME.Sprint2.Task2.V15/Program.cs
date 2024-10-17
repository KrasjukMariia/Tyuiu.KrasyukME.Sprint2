using Tyuiu.KrasyukME.Sprint2.Task2.V15.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task2.V15
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
            Console.WriteLine("*                              Задание #2                                 *");
            Console.WriteLine("*                              Вариант #15                                 *");
            Console.WriteLine("* Выполнил: Красюк Мария Евгеньевна    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");

            int x, y;
            Console.WriteLine("Введите значение x ");
            x = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Введите значение y ");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadLine();
        }
    }
}
