using System;

namespace LR2
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
                    "Программа реализует такие задачи:\n1). Вырез текста\n2). Целочисленный список"+
                    "\n3). Фильтрация по первой букве в названи\n4). Фильтрация по части строки\n"+
                    "5). Нахождение элементов по заданному промежутку\n6). Сортировка\n7). Сложная фильтрация\nДля выхода введите 0 или exit.");
                task = Console.ReadLine();
                switch (task)
                {
                    case "0":
                    case "exit":
                        return;
                    case "1":
                        Console.WriteLine("Вырезка текста.");
                        while (true)
                        {
                            Text text = new Text();
                            text.CutLine();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Целочисленный массив.\nВведите числа через запятую.");
                        while (true)
                        {
                           List();
                           if (EXIT())
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Фильтрация по первой букве в названии");
                        while (true)
                        {
                            Film film=new Film();
                            film.FiltreByName();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Фильтрация по части слова");
                        while (true)
                        {
                            Film film = new Film();
                            film.FiltreByPart();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Нахождение элементов по заданному промежутку");
                        while (true)
                        {
                            Film film = new Film();
                            film.FindElements();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Сортировка");
                        while (true)
                        {
                            Film film = new Film();
                            film.Sort();
                            if (EXIT())
                                break;
                        }
                        break;
                    case "7":
                        Console.WriteLine("Двойной фильтр(жанр+рейтинг):");
                        while (true)
                        {
                            Film film = new Film();
                            film.DoubleFiltre();
                            if (EXIT())
                                break;
                        }
                        break;
               }
            }
        }

        static bool EXIT()
        {
            string exit;
            Console.WriteLine("\nДля выхода введите 0/exit. Иначе Enter.");
            exit = Console.ReadLine();
            if (exit == "0" || exit == "exit")
                return true;
            return false;
        }

        static void List()
        {
            try
            {
                string line = Console.ReadLine().Replace('.', ',').Trim(' ');
                if (line.Length == 0)
                {
                    throw new ProgramException("\nВы ничего не ввели.");
                }
                for (int i = 0; i < line.Length; i++)
                {
                    if ((line[i] < '0' || line[i] > '9') && line[i] != ',')
                    {
                        throw new ProgramException("\nОшибка ввода");
                    }
                }
                IntList intList = new IntList(line);
                intList.Menu();
            }
            catch (Exception e)
            { }
        }
    }
}