using System;

class Line
{
    private String line;

    public Line()
    {
        Console.WriteLine("¬ведите строку:");
        this.line = Console.ReadLine();
    }

    public void CountWordsAndLetters()
    {
        int countWords = 0, countLetters = 0;
        countLetters = this.line.Length;
        string[] words = this.line.Split(' ');
        countWords = words.Length;
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Trim(':', ';', '?', '.', ',', '-', '!', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                '0');
            if (words[i].Length == 0)
                countWords--;
        }
        this.line += "-" + countLetters + "-" + countWords;
        Console.WriteLine(line);
    }
}