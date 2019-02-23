using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Namespace - объявления области действия, которая содержит набор связанных объектов.
Пространство имен можно использовать для организации элементов кода и
для создания глобально уникальных типов. */

namespace Project1
{
    // Объявление класса Program
    class Program
    {
        private static readonly object console;

        //Вызов метода Main
        static void Main(string[] args)
        {
            //Метод Writeline выводит информацию на экран
            Console.WriteLine("Первая программа на С#");
            Console.ReadLine();

            Console.WriteLine("UPS");
            Console.ReadLine(); /*Метод ReadLine читает все символы
                                    в строке из стандартного ввода*/


            int a = 1;
            {
                Console.WriteLine("a: " + a);
                Console.ReadLine();
            }


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }

            Console.WriteLine();

            string[] Arr = new string[] { "Одесский", "Национальный", "Политехнический", "Университет", };
            int p = 0;
            while (p < 4)
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет           
                Console.WriteLine(Arr[p]);
                p++;
                Console.ReadKey();
                Console.ResetColor(); // сбрасываем в стандартный          
            }

            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет 
            Console.WriteLine("Конец");
            Console.ReadKey();
            Console.ResetColor(); // сбрасываем в стандартный
            
        }
    }    
}