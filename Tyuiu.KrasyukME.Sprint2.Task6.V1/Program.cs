using Tyuiu.KrasyukME.Sprint2.Task6.V1.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Красюк.М.Е. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #2                              *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("*                              Задание #6                                 *");
            Console.WriteLine("*                              Вариант #1                                 *");
            Console.WriteLine("* Выполнил: Красюк Мария Евгеньевна    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер месяца: ");
            int numMonth = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Количество дней в этом месяце: " + ds.FindMonthDaysCount(numMonth);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
