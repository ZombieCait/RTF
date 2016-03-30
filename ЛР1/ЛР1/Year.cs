using System;
using System.Runtime.Remoting.Messaging;

class Year
{
    private int year;

    public Year()
    {
        Console.WriteLine("Введите год:");
        this.year = int.Parse(Console.ReadLine());
    }

    public void IsLeapYear()
    {
        if (year < 1 || year > 9999)
        {
            Console.WriteLine("Ошибка ввода, год должен быть задан в промежутке от 1 до 9999");
            return;
        }
        if (DateTime.IsLeapYear(this.year))
            Console.WriteLine("Год " + this.year + " високосный.");
        else
            Console.WriteLine("Год " + this.year + " не високосный.");
    }
}