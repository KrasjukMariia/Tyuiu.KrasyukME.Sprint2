using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrasyukME.Sprint2.Task2.V15.Lib
{

    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x <= 5) || (x >= 9 && x <= 12) && (y >= 3 && y <= 4))
            {
                return true;
            }
            if ((x >= 2 && x <= 12) && (y == 5 ))
            {
                return true;
            }
            if ((x >= 2 && x <= 13) && (y == 6))
            {
                return true;
            }
            if ((x >= 3 && x <= 13) && (y == 7))
            {
                return true;
            }
            if ((x >= 6 && x <= 13) && (y == 8))
            {
                return true;
            }
            if ((x >= 5 && x <= 6) || (x >= 11 && x <= 12) && (y >= 9 && y <= 10))
            {
                return true;
            }
            if ((x == 5) || (x >= 11 && x <= 12) && (y == 11))
            {
                return true;
            }
            if ((x >= 4 && x <= 6) || (x >= 12 && x <= 13) && (y == 12))
            {
                return true;
            }
            if ((x >= 2 && x <= 3) && (y == 13))
            {
                return true;
            }


            return false;
        }
    }
   
}
