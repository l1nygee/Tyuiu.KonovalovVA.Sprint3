using Tyuiu.KonovalovVA.Sprint3.Task1.V28.Lib;
namespace Tyuiu.KonovalovVA.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeriesValid()
        {
            DataService ds = new DataService();
            double v = 0.25;
            int st = 1;
            int en = 18;
            double wait = -0.123;
            double res = ds.GetSumSeries(v, st, en);
            Assert.AreEqual(wait, res);
        }
    }
}