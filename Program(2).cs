using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks
{
    class Program
    {

		// Предикатная функция для проверки строки
        private static bool checkSize(string str)
        {
            return (str.Length <= 3);
        }

		// Парсинг списка
        public static string[] parseInput(string[] arr)
        {
		   // Используем предикат выше
           return arr.Where(checkSize).ToArray();
        }
        public static string[] parseInput(ref List<string> list)
        {
            return list.Where(checkSize).ToArray();
        }

		// Убирает лишний символ новой строки из строки, ее содержащей
        public static string removeNL(string str)
        {
            if (str.EndsWith("\n")) {
                str.Remove(str.Length - 3, 2);
            }
            return str;
        }

        public static void Main(string[] args) {
            // Если аргументов нет
            if (args.Length == 0)
            {
                Console.WriteLine("Input lines. When done, send empty line with Enter");
                // Используем список, т.к. кол-во строк заранее неизвестно
                List<string> strList = new List<string>();
				
				//Считываем ввод
                while (true)
                {
                    string buffer = Console.ReadLine(); // берем строку из ввода
                    if (buffer == "" || buffer == "\n") { // если enter, или пустая строка - начинаем обработку
                        break;
                    }
                    else {
                        buffer = removeNL(buffer); // убираем лишний символ новой строки
                        strList.Add(buffer); // добавляем строку в список
                        buffer = ""; // очищаем буфер
                    }
                }
				
				// обработка введенных строк
                string[] resArr = parseInput(ref strList);
                Console.WriteLine("Result:");
                foreach (string str in resArr) {
                    Console.WriteLine("{0} ", str);
                }
                Console.WriteLine("\b\b"); //форматируем вывод
            }
            else {
				//Парсим аргументы
                string[] strArr = new string[args.Length];
                args.CopyTo(strArr, 1); // копируем аргументы в массив строк
                Console.WriteLine("Result:");
                foreach (string str in parseInput(strArr)) { // парсим строки
                    Console.WriteLine("{0} ", str);
                }
                Console.WriteLine("\b\b"); //форматируем вывод
            }
            Console.ReadLine();
        }
    }
}
