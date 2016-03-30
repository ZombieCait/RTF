using System;

class Function
{
    private int x;

    public Function()
    {
        Console.WriteLine("¬ведите целое число:");
        this.x = int.Parse(Console.ReadLine());
    }

    public void CalculateFunction()
    {
        if (this.x%2 == 0)
            Console.WriteLine("F(x)={0:f3}", Math.Sqrt(x));
        else
            Console.WriteLine("F(x)={0:f2}", Math.Pow(x, 1/3f));
    }
}