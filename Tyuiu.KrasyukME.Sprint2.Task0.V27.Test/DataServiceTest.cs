using Tyuiu.KrasyukME.Sprint2.Task0.V27.Lib;

namespace Tyuiu.KrasyukME.Sprint2.Task0.V27.Test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new bool[] { true, false, true, false, false, true }, ds.GetCompareOperations(1305, 275));
        }
    }
}