using System;

class Mark
{
    private string point;

    public Mark()
    {
        Console.WriteLine("������� ������ 1 �� 10:");
        this.point = Console.ReadLine();
    }

    public void GetMark()
    {
        switch (point)
        {
            case "1":
            case "2":
                Console.WriteLine("�����.");
                break;
            case "3":
            case "4":
            case "5":
                Console.WriteLine("�����������������.");
                break;
            case "6":
            case "7":
            case "8":
                Console.WriteLine("������.");
                break;
            case "9":
            case "10":
                Console.WriteLine("�������.");
                break;
            case "0":
            case "exit":
                break;
            default:
                Console.WriteLine("������������ ���� ������");
                break;
        }
    }
}