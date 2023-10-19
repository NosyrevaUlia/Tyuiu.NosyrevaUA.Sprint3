using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosyrevaUA.Sprint3.Task3.V18.Lib;

namespace Tyuiu.NosyrevaUA.Sprint3.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Носырева Ю. А.| ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла foreach                                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Носырева Юлия Алексеевна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву n в строке: 4n5nvf 56    *");
            Console.WriteLine("* bgy                                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string str = "4n5nvf 56 bgy";
            char n = 'n';
            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Символ на замену цифрам: " + n);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Полученная строка: " + ds.ReplaceNumOnChar(str, n));
            Console.ReadLine();

        }
    }
}
