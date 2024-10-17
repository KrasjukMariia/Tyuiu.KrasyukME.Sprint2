using Tyuiu.KrasyukME.Sprint2.Task1.V11.Lib;
namespace Tyuiu.KrasyukME.Sprint2.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new bool[] { false, false, true, false, true, false }, ds.GetLogicOperations(145, 156, 142, 117));
        }
    }
}