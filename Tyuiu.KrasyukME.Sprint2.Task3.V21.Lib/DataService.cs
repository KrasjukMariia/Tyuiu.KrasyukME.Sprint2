using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrasyukME.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 1)
            {
                y = Math.Round(x * ((x + 9) / (x - 1)), 3);
                return y;
            }
            else if (x == 0)
            {
                y = Math.Round((Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - (Math.Sin(Math.Pow(x, 2)) + 12)), 3);
                return y;
            }
            else if (-25 < x && x < 2)
            {
                y = Math.Round(1 + (1 / Math.Pow(x, 2)), 3);
                return y;

            }
            else if (x < -25)
            {
                y = Math.Round(x + 10 * x - (1 / x), 3);
                return y;
            }
            else { return -1; }
        }
    }
}
