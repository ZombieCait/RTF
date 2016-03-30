using System;

class Triangle
{
    private double high;
    private double side1;
    private double side2;
    private double side3;
    private double angle;
    private double square;
    private string EXIT;

    public void CalculateTriangleSquare()
    {
        while (true)
        {
            Console.WriteLine(
                "1. Сторона и высота; \n2. Три стороны.\n3. Две стороны и угол.\nДля выхода введите 0 или exit.\nВведите вариант: ");
            string task = Console.ReadLine();
            switch (task)
            {
                case "0":
                case "exit":
                    return;
                case "1":
                    this.GetSquare_HeightSide();
                    break;
                case "2":
                    this.GetSquare_ThreeSides();
                    break;
                case "3":
                    this.GetSquare_SidesAngle();
                    break;
            }
        }
    }

    void GetSquare_HeightSide()
    {
        while (true)
        {
            Console.WriteLine("Введите длину стороны:");
            this.side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину высоты:");
            this.high = int.Parse(Console.ReadLine());
            this.square = this.side1*this.high/2.0;
            Console.WriteLine("Площадь треугольника: {0}", this.square);
            Console.WriteLine("Для выхода введите 0/exit. Иначе Enter.");
            EXIT = Console.ReadLine();
            if (EXIT == "0" || EXIT == "exit")
                break;
        }
    }

    void GetSquare_ThreeSides()
    {
        while (true)
        {
            Console.WriteLine("Введите длины сторон через Enter:");
            this.side1 = double.Parse(Console.ReadLine());
            this.side2 = double.Parse(Console.ReadLine());
            this.side3 = double.Parse(Console.ReadLine());
            if (this.IsTriangle())
            {
                double P = side1 + side2 + side3;
                this.square = Math.Sqrt(P*(P - side1)*(P - side2)*(P - side3));
            }
            else
            {
                Console.WriteLine("Не является треугольником.");
                return;
            }
            Console.WriteLine("Площадь треугольника: {0}", this.square);
            Console.WriteLine("Для выхода введите 0/exit. Иначе Enter.");
            EXIT = Console.ReadLine();
            if (EXIT == "0" || EXIT == "exit")
                break;
        }
    }

    void GetSquare_SidesAngle()
    {
        while (true)
        {
            Console.WriteLine("Введите длины сторон через Enter:");
            this.side1 = double.Parse(Console.ReadLine());
            this.side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите угол:");
            this.angle = Math.PI*double.Parse(Console.ReadLine())/180.0;
            this.square = 0.5*side1*side2*Math.Sin(this.angle);
            Console.WriteLine("Площадь треугольника: {0}", this.square);
            Console.WriteLine("Для выхода введите 0/exit. Иначе Enter.");
            EXIT = Console.ReadLine();
            if (EXIT == "0" || EXIT == "exit")
                break;
        }
    }

    bool IsTriangle()
    {
        if ((side1 + side2) > side3 && (side2 + side3) > side1 && (side1 + side3) > side2)
            return true;
        return false;
    }
}