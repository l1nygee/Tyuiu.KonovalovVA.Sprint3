using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KonovalovVA.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res += (Math.Pow(value, i) + 0.25) * Math.Cos(i);
            }
            return Math.Round(res,3);
        }
    }
}
