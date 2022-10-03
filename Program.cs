using System;
public class MainClass
{
    static int Vvod_Chisla_Int()
    {
        int chislo;
        string vvod;
        vvod = Console.ReadLine();
        while (!Int32.TryParse(vvod, out chislo))
        {
            Console.WriteLine("Недопустимые символы в строке ввода. Ожидается целое число:");
            vvod = Console.ReadLine();
        }
        return chislo;
    }
    static void Main(string[] args)
    {
        int a;
        Console.Write("Введите трехзначное число (число десятков и единиц != 0):");
        a = Vvod_Chisla_Int();
        while (a > 999 || a % 10 == 0 || a % 100 == 0)
        {
            Console.Write("Введенное число вне диапазона допустимых значений. Повторите ввод:");
            a = Vvod_Chisla_Int();
        }
        Console.WriteLine("Ответ: {0}", a % 10 * 100 + a % 100 / 10 * 10 + a / 100);
        Console.WriteLine();
        Console.ReadKey();
    }
}

