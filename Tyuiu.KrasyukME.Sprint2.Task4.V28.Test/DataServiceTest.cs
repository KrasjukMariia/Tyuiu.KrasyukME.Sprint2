using Tyuiu.KrasyukME.Sprint2.Task4.V28.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
      
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1.787, res);
        }

    }
}