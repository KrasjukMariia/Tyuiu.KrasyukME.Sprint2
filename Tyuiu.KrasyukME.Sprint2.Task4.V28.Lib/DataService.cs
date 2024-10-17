using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrasyukME.Sprint2.Task4.V28.Lib
{
    public class DataService : ISprint2Task4V28
    {
        public double Calculate(double x, double y)
        {

                double z = x < y * 2 - 10 ? (Math.Pow((1 + (y + 2) / (x * x)), x)) : 
                ((2 * (x * x) - Math.Cos(y*y) + 12) / (y * y - Math.Sin(x * x) + 9));
                return Math.Round(z, 3);
            

        }
    }
}
