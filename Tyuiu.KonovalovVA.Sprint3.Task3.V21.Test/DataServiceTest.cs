using Tyuiu.KonovalovVA.Sprint3.Task3.V21.Lib;
namespace Tyuiu.KonovalovVA.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceNumOnCharValid()
        {
            string s = "f3g5ht g4j 34kg4";
            DataService ds = new DataService();
            string res = ds.ReplaceNumOnChar(s,'e');
            string wait = "fegeht gej eekge";
            Assert.AreEqual(wait, res);

        }
    }
}