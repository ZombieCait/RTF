using System;
using System.Linq;

class NaturalNumbers
{
    private uint[] naturalNumbers;
    private uint sumNumbers;

    public NaturalNumbers()
    {
        Console.WriteLine("¬ведите натуральные числа через пробел:");
        string[] numbers = Console.ReadLine().Split(' ');
        naturalNumbers = new uint[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            naturalNumbers[i] = uint.Parse(numbers[i]);
        }
    }

    public void SumNaturalNumbers()
    {

        for (int i = 0; i < naturalNumbers.Count(); i++)
        {
            this.sumNumbers += naturalNumbers[i];
        }
        Console.WriteLine("—умма чисел {0}", this.sumNumbers);
    }
}