using Tyuiu.KonovalovVA.Sprint3.Task0.V22.Lib;
namespace Tyuiu.KonovalovVA.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesValid()
        {
            double a = 0.25;
            int st = 1;
            int en = 8;
            DataService ds = new DataService();
            double wait = 31.328;
            double ans = ds.GetMultiplySeries(a, st, en);
            Assert.AreEqual(wait, ans);
        }
    }
}