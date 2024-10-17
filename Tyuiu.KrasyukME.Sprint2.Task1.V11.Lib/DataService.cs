using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KrasyukME.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];
            results[0] = a > b;
            results[1] = a < d;
            results[2] = (a == c) | (b > c);
            results[3] = (b == d) & (c > a);
            results[4] = (a < c) ^ (b > d);
            results[5] = a != b;

            return results;
        }
    }
}
