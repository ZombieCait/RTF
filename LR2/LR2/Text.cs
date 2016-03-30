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
                Console.WriteLine("������� �����:");
                text = Console.ReadLine().ToLower();
                Console.WriteLine("������� ����� � �������� �������� �������: ");
                start = Console.ReadLine().ToLower();
                Console.WriteLine("������� ����� �� ������� ��������� �������: ");
                stop = Console.ReadLine().ToLower();
                if (text.Length == 0 || start.Length == 0 || stop.Length == 0)
                {
                    Console.WriteLine("�� ������ ������ ������.");
                }
                if (Equals(text, start) || Equals(text, stop) || Equals(start, stop))
                {
                    throw new ProgramException("�� �������� �������� �����.");
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("�� ������ ������ ������.");
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
                    throw new ProgramException("��� ������ ��� ���������.");
                }

                int endIndex = end - start.Length - 1;
                var result = text.Substring(startIndex, endIndex);
                Console.WriteLine("�������� ������: {0}", result);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("�� ������� �������� �����, ������ ��� " + e.Message);
            }
            catch 
            {
            }
        }
    }
}