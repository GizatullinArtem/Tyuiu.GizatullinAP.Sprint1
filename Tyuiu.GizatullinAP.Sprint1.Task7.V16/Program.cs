﻿using Tyuiu.GizatullinAP.Sprint1.Task7.V16.Lib;
namespace Tyuiu.GizatullinAP.Sprint1.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Cпринт #1 | Выполнил: Гизатуллин А.П. | ИСПб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Работа со строками класс String                                    *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #16                                                              *");
            Console.WriteLine("* Выполнил: Гизатуллин Артём Павлович  | ИСПб-24-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите x");
            double a = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(a);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
