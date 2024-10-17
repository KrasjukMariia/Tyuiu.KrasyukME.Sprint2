using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KrasyukME.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];
            results[0] = x > y;
            results[1] = x < y;
            results[2] = x == (y + 1030);
            results[3] = x != (y + 1000);
            results[4] = x <= (y + 1000);
            results[5] = y >= (x - 1030);

            return results;

        }
    }
}
