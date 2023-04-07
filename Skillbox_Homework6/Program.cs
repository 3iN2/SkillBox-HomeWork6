using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Skillbox_Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите 1 чтобы внести информцию в файл.\nВведите 2 чтобы считать информцию из файла.");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    #region Ввод новой информации в файл
                    using (StreamWriter sw = new StreamWriter("Guide.txt", true, Encoding.Unicode))
                    {
                        char key = 'д';
                        do
                        {
                            string name = string.Empty;

                            string nowData = DateTime.Now.ToString();
                            Console.WriteLine($"Время записи: {nowData}");
                            name += $"{nowData}#";

                            Console.WriteLine("\nВведите Ф.И.О сотрудника: ");
                            name += $"{Console.ReadLine()}#";

                            Console.WriteLine("\nВведите ID сотрудника: ");
                            name += $"{Console.ReadLine()}#";

                            Console.WriteLine("\nВведите возраст: ");
                            name += $"{Console.ReadLine()}#";

                            Console.WriteLine("\nВведите рост (см) ");
                            name += $"{Console.ReadLine()}#";

                            Console.WriteLine("\nВведите город рождения: ");
                            name += $"{Console.ReadLine()}";

                            sw.WriteLine(name);

                            Console.WriteLine("Ввести данные следующего сотрудника? н/д");
                            key = Console.ReadKey().KeyChar;
                        } while (char.ToLower(key) == 'д');
                    }
                    #endregion
                }
                if (choice == 2)
                {
                    #region Вывод иноформации из файла
                    using (StreamReader sw = new StreamReader("Guide.txt", Encoding.Unicode))
                    {
                        string line;

                        while ((line = sw.ReadLine()) != null)
                        {
                            string[] data = new string[6];
                            data = line.Split('#');
                            Console.WriteLine($" Дата записи: {data[0]}\n Ф.И.О. сотрудника: {data[1]}\n" +
                                $" ID: {data[2]}\n Возраст: {data[3]}\n Рост (см): {data[4]}\n Город рождения: {data[5]}");
                            Console.WriteLine("\n");
                        }
                    }
                    #endregion
                }
                else
                {
                    Console.WriteLine("\n");
                    continue;
                }
            }
        }
    }
}
