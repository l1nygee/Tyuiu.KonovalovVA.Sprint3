using Tyuiu.KonovalovVA.Sprint3.Task7.V14.Lib;
namespace Tyuiu.KonovalovVA.Sprint3.Task7.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int st, en;
            Console.WriteLine("Введите st,en");
            st = Convert.ToInt32(Console.ReadLine());
            en = Convert.ToInt32(Console.ReadLine());
            Console.Title = "Спринт #3 | Выполнил: Коновалов В.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Коновалов Владимир Артёмович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* st = " + st);
            Console.WriteLine("* en = " + en);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetMassFunction(st, en));

        }
    }
}
