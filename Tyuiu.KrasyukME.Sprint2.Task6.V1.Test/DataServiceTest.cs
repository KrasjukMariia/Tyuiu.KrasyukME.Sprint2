using Tyuiu.KrasyukME.Sprint2.Task6.V1.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindMonthDaysCount()
        {
            DataService ds = new DataService();

            Assert.AreEqual(31, ds.FindMonthDaysCount(1));
            Assert.AreEqual(28, ds.FindMonthDaysCount(2));
            Assert.AreEqual(31, ds.FindMonthDaysCount(3));
            Assert.AreEqual(30, ds.FindMonthDaysCount(4));
            Assert.AreEqual(31, ds.FindMonthDaysCount(5));
            Assert.AreEqual(30, ds.FindMonthDaysCount(6));
            Assert.AreEqual(31, ds.FindMonthDaysCount(7));
            Assert.AreEqual(31, ds.FindMonthDaysCount(8));
            Assert.AreEqual(30, ds.FindMonthDaysCount(9));
            Assert.AreEqual(31, ds.FindMonthDaysCount(10));
            Assert.AreEqual(30, ds.FindMonthDaysCount(11));
            Assert.AreEqual(31, ds.FindMonthDaysCount(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(20);
            });
        }
    }
}