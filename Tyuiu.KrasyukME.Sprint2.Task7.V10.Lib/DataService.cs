using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KrasyukME.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (x > 0)
            {
                if ((x * x - y <= 2) && (y - x <= 0) && (y + x >= 0))
                { res = true; }

                else { res = false; }

            }

            else
            {
                if ((x * x - y <= 2) && (y - x >= 0) && (y + x <= 0))
                { res = true; }

                else { res = false; }

            }
            return res;
        }
    }
}
