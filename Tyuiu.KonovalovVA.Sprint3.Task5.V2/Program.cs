namespace Tyuiu.KonovalovVA.Sprint3.Task5.V2.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x,st1,st2,en1,en2;
        Console.WriteLine("Введите x,st1,st2,en1,en2");
        x = Convert.ToInt32(Console.ReadLine());
        st1 = Convert.ToInt32(Console.ReadLine()); 
        st2 = Convert.ToInt32(Console.ReadLine());
        en1 = Convert.ToInt32(Console.ReadLine());
        en2 = Convert.ToInt32(Console.ReadLine());
        Console.Title = "Спринт #3 | Выполнил: Коновалов В.А. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Коновалов Владимир Артёмович | ПКТб-24-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* x = " + x);
        Console.WriteLine("* st1 = " + st1);
        Console.WriteLine("* st2 = " + st2);
        Console.WriteLine("* en1 = " + en1);
        Console.WriteLine("* en2 = " + en2);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetSumSumSeries(x,st1,st2,en1,en2));
    }
}
