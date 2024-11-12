using Tyuiu.KonovalovVA.Sprint3.Task4.V12.Lib;

namespace Tyuiu.KonovalovVA.Sprint3.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            int st = -5;
            int en = 5;
            double wait = 467.59;
            DataService ds = new DataService();
            double res = ds.Calculate(st, en);
            Assert.AreEqual(wait, res);
        }
    }
}