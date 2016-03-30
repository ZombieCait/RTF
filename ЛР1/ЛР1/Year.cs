using System;
using System.Runtime.Remoting.Messaging;

class Year
{
    private int year;

    public Year()
    {
        Console.WriteLine("������� ���:");
        this.year = int.Parse(Console.ReadLine());
    }

    public void IsLeapYear()
    {
        if (year < 1 || year > 9999)
        {
            Console.WriteLine("������ �����, ��� ������ ���� ����� � ���������� �� 1 �� 9999");
            return;
        }
        if (DateTime.IsLeapYear(this.year))
            Console.WriteLine("��� " + this.year + " ����������.");
        else
            Console.WriteLine("��� " + this.year + " �� ����������.");
    }
}