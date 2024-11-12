using Tyuiu.KonovalovVA.Sprint3.Task3.V21.Lib;
namespace Tyuiu.KonovalovVA.Sprint3.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string s;
            char c;
            Console.WriteLine("Введите строку и символ");
            s = Console.ReadLine();
            c = Convert.ToChar(Console.ReadLine);  
            Console.Title = "Спринт #3 | Выполнил: Коновалов В.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Коновалов Владимир Артёмович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* s = " + s);
            Console.WriteLine("* c = " + c);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ReplaceNumOnChar(s, c));
        }
    }
}
