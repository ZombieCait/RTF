using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LR2
{
    public class IntList
    {
        List<int> list;

        public IntList(string line)
        {
            try
            {
                string[] numbers = line.Split(new char[] {' ', ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                list = new List<int>(numbers.Length);
                for (int i = 0; i < numbers.Length; i++)
                    list.Add(int.Parse(numbers[i]));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка во время выполнения.");
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Сумма чисел; \n2. Среднее арифметическое.\n3. Минимум. \n4. Максимум." +
                                  "\n5. Все\nДля выхода введите 0 или exit.\nВведите вариант: ");
                string task = Console.ReadLine();
                switch (task)
                {
                    case "0":
                    case "exit":
                        return;
                    case "1":
                        this.Sum();
                        break;
                    case "2":
                        this.Average();
                        break;
                    case "3":
                        this.Minimum();
                        break;
                    case "4":
                        this.Maximum();
                        break;
                    case "5":
                        this.Sum();
                        this.Average();
                        this.Minimum();
                        this.Maximum();
                        break;
                }
            }
        }

        private void Sum()
        {
            Console.WriteLine("Среднее арифметическое {0}", list.Sum());
        }

        private void Average()
        {
            Console.WriteLine("Среднее арифметическое {0}", list.Average());
        }

        private void Minimum()
        {
            Console.WriteLine("Минимум функции {0}", list.Min());
        }

        private void Maximum()
        {
            Console.WriteLine("Максимум функции {0}", list.Max());
        }
    }
}