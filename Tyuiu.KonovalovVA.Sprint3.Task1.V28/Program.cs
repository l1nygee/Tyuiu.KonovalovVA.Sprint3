using Tyuiu.KonovalovVA.Sprint3.Task1.V28.Lib;
namespace Tyuiu.KonovalovVA.Sprint3.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double a;
            int st, en;
            Console.WriteLine("Введите a,start,end");
            a = Convert.ToDouble(Console.ReadLine());
            st = Convert.ToInt32(Console.ReadLine());
            en = Convert.ToInt32(Console.ReadLine());
            Console.Title = "Спринт #3 | Выполнил: Коновалов В.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Коновалов Владимир Артёмович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = " + a);
            Console.WriteLine("* st = " + st);
            Console.WriteLine("* en = " + en);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSeries(a, st, en));
        }
    }
}
