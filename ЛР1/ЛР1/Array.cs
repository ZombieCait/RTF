using System;

class Array
{
    private string array;
    private int size;
    public Array()
    {
        Console.WriteLine("������� 30 ��������. ����� ��������� ���� ������ ������� '?'");
        char [] arrayChars=new char[30];
        for (int i =0; i < 30; i++)
        {
            arrayChars[i]=Console.ReadKey().KeyChar;
            if (arrayChars[i] == '?')
            {
                this.array = new string(arrayChars);
                this.size = i;
                break;
            }
        }
        this.array = new string(arrayChars);
    }

    public void GetThreeLine()
    {
        if (this.size == 0)
        {
            Console.WriteLine("\n������ ������.");
            return;
        }
        this.array = this.array.Remove(size);
        int sizeLine=this.array.Length/3;
        int remainder = this.array.Length%3;
        string first = this.array.Remove(sizeLine+remainder);
        string second = this.array.Remove(0, sizeLine + remainder);
        second = second.Remove(sizeLine + remainder);
        string third = this.array.Remove(0,remainder+sizeLine*2);
        Console.WriteLine("\n��������� ������ ���������:\n{0}",first);
        Console.WriteLine(second);
        Console.WriteLine(third);
    }
}