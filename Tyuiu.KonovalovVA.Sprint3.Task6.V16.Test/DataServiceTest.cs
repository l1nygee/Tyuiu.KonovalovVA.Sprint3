using Tyuiu.KonovalovVA.Sprint3.Task6.V16.Lib;
namespace Tyuiu.KonovalovVA.Sprint3.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisorsValid()
        {
            DataService ds = new DataService();
            int st = 5;
            int en = 16;
            int wait = 42;
            int res = ds.GetSumTheDivisors(st, en);
            Assert.AreEqual(wait, res);
        }
    }
}