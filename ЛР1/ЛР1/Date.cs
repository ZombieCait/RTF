using System;

class Date
{
    private DateTime firstDate;
    private DateTime secondDate;

    public Date()
    {
        Console.WriteLine("¬ведите дату через пробел число\\мес€ц\\год:");
        firstDate = DateTime.Parse(Console.ReadLine());
        secondDate = DateTime.Now;
    }

    public void ToDateTimeDiff()
    {
        TimeSpan result = this.secondDate - this.firstDate;
        int differenceInDays = result.Days;
        if (differenceInDays < 0)
            differenceInDays = -differenceInDays;
        Console.WriteLine("–азница между текущей датой и введенной датой: " + differenceInDays);
    }
}