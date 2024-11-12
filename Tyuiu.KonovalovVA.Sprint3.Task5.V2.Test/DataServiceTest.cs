namespace Tyuiu.KonovalovVA.Sprint3.Task5.V2.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GetSumSumSeriesValid()
    {
        int x = 5;
        DataService ds = new DataService();
        int st1 = 1;
        int st2 = 1;
        int en1 = 3;
        int en2 = 12;
        double res = ds.GetSumSumSeries(x, st1, st1,en1,en2);
        double wait = 35.658;
        Assert.AreEqual(wait,res);
    }
}