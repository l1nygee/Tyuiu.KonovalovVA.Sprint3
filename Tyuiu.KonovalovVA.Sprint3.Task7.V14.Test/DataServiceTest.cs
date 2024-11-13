using Tyuiu.KonovalovVA.Sprint3.Task7.V14.Lib;
namespace Tyuiu.KonovalovVA.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int st = -5;
            int en = 5;
            int len = en - st + 1;
            double[] res = new double[len];
            res[0] = -19.62;
            res[1] = -17.12;
            res[2] = -18.15;
            res[3] = -63.13;
            res[4] = -24.92;
            res[5] = -5;
            res[6] = -1.46;
            res[7] = 1.57;
            res[8] = 6.38;
            res[9] = 32.78;
            res[10] = 225.11;
            double[] rt;
            rt = ds.GetMassFunction(st,en);
            CollectionAssert.AreEqual(res, rt);
        }
    }
}