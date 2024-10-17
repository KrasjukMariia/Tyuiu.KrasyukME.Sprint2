using Tyuiu.KrasyukME.Sprint2.Task2.V15.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            int y = 3;

            DataService ds = new DataService();

            Assert.AreEqual( true , ds.CheckDotInShadedArea(3, 3));

        }
    }
}