using Tyuiu.GizatullinAP.Sprint1.Task6.V11.Lib;

namespace Tyuiu.GizatullinAP.Sprint1.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Гизатуллин А. П. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Гизаутллин Артём Павлович | ИСПб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу :пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что первая буква строки входит в нее еще раз.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            String str = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:      true/false                                              *");
            Console.WriteLine("***************************************************************************");
            bool b = ds.CheckeFirstLetterRepetition(str);
            Console.WriteLine(b);
        }
    }
}
