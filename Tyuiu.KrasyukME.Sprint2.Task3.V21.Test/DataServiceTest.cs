using Tyuiu.KrasyukME.Sprint2.Task3.V21.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;

            var res = ds.Calculate(x);
            Assert.AreEqual(0.833, res);
        }
    }
}