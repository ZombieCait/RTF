using System;

namespace ЛР1
{
    class Program
    {
        static void Main(string[] args)
        {
            string task;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "Программа реализует такие задачи:\n1). Подсчет количества символов и слов в строке.\n2). Проверка является ли заданный год високосным." +
                    "\n3). Вычисление разницы между текущей датой и введенной." +
                    "\n4). Анализ рандомных чисел.\n5). Площадь треугольника. \n6). Сумма натуральных чисел.\n7). Вычисление функции в зависимости от чётности числа."
                    +
                    "\n8). Интерпретация оценки.\n9). Символьный массив.\n10). Матрицы.\n11). Калькулятор целочисленных выражений.\nДля выхода введите 0 или exit.");
                task = Console.ReadLine();
                switch (task)
                {
                    case "0":
                    case "exit":
                        return;
                    case "1":
                        Console.WriteLine("Подсчет количества символов и слов в строке.");
                        while (true)
                        {
                            Line line = new Line();
                            line.CountWordsAndLetters();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Определение является ли заданный год високосным.");
                        while (true)
                        {
                            Year year = new Year();
                            year.IsLeapYear();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Вычисление разницы между текущей датой и введенной.");
                        while (true)
                        {
                            Date date = new Date();
                            date.ToDateTimeDiff();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Анализ рандомных чисел.");
                        RandomNumbers randNumbers = new RandomNumbers();
                        while (true)
                        {
                            randNumbers.AnalyzeRandomlyNumbers();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Вычисление площади треугольника.");
                        Triangle triangle = new Triangle();
                        triangle.CalculateTriangleSquare();
                        break;
                    case "6":
                        Console.WriteLine("Сумма натуральных чисел.");
                        while (true)
                        {
                            NaturalNumbers naturalNumbers = new NaturalNumbers();
                            naturalNumbers.SumNaturalNumbers();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "7":
                        Console.WriteLine("Вычисление функции в зависимости от чётности числа.");
                        while (true)
                        {
                            Function function = new Function();
                            function.CalculateFunction();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "8":
                        Console.WriteLine("Перевод десятибалльной оценки.");
                        while (true)
                        {
                            Mark mark = new Mark();
                            mark.GetMark();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "9":
                        Console.WriteLine("Символьный массив.");
                        while (true)
                        {
                            Array array = new Array();
                            array.GetThreeLine();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "10":
                        Console.WriteLine("Матрица.");
                        while (true)
                        {
                            Matrix matrix = new Matrix();
                            matrix.Replace();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "11":
                        Console.WriteLine("Калькулятор.");
                        while (true)
                        {
                            Calculator calculator = new Calculator();
                            calculator.InputExpression();
                            if (EXIT())
                                break;
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
        static bool EXIT()
        {
            string exit;
            Console.WriteLine("Для выхода введите 0/exit. Иначе Enter.");
            exit = Console.ReadLine();
            if (exit == "0" || exit == "exit")
                return true;
            return false;
        }
    }
}