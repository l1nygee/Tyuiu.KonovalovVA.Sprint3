using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KonovalovVA.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int number = startValue; number <= stopValue; number++)
            {
                int div = 0;
                for (int d = 1; d <= number; d++)
                    if (number % d == 0) div++;
                res += div;
            }
            return res;
        }
    }
}
