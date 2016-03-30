using System;

namespace LR2
{
    public class Text
    {
        private string text;
        private string start;
        private string stop;

        public void CutLine()
        {
            try
            {
                Console.WriteLine("Введите текст:");
                text = Console.ReadLine().ToLower();
                Console.WriteLine("Введите слово с которого начинать вырезку: ");
                start = Console.ReadLine().ToLower();
                Console.WriteLine("Введите слово на котором закончить вырезку: ");
                stop = Console.ReadLine().ToLower();
                if (text.Length == 0 || start.Length == 0 || stop.Length == 0)
                {
                    Console.WriteLine("Вы забыли ввести данные.");
                }
                if (Equals(text, start) || Equals(text, stop) || Equals(start, stop))
                {
                    throw new ProgramException("Не возможно вырезать текст.");
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Вы забыли ввести данные.");
            }
            catch
            {
            }
            Cut();
        }

        private void Cut()
        {
            try
            {
                int begin = text.IndexOf(start);
                int end = text.IndexOf(stop);
                int startIndex = begin + start.Length;
                if (text[start.Length] == ' ')
                    startIndex++;

                if (startIndex == end)
                {
                    throw new ProgramException("Нет текста для вырезания.");
                }

                int endIndex = end - start.Length - 1;
                var result = text.Substring(startIndex, endIndex);
                Console.WriteLine("Получена строка: {0}", result);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Не удалось вырезать текст, потому что " + e.Message);
            }
            catch 
            {
            }
        }
    }
}