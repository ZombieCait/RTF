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
                "1. ������� � ������; \n2. ��� �������.\n3. ��� ������� � ����.\n��� ������ ������� 0 ��� exit.\n������� �������: ");
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
            Console.WriteLine("������� ����� �������:");
            this.side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("������� ����� ������:");
            this.high = int.Parse(Console.ReadLine());
            this.square = this.side1*this.high/2.0;
            Console.WriteLine("������� ������������: {0}", this.square);
            Console.WriteLine("��� ������ ������� 0/exit. ����� Enter.");
            EXIT = Console.ReadLine();
            if (EXIT == "0" || EXIT == "exit")
                break;
        }
    }

    void GetSquare_ThreeSides()
    {
        while (true)
        {
            Console.WriteLine("������� ����� ������ ����� Enter:");
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
                Console.WriteLine("�� �������� �������������.");
                return;
            }
            Console.WriteLine("������� ������������: {0}", this.square);
            Console.WriteLine("��� ������ ������� 0/exit. ����� Enter.");
            EXIT = Console.ReadLine();
            if (EXIT == "0" || EXIT == "exit")
                break;
        }
    }

    void GetSquare_SidesAngle()
    {
        while (true)
        {
            Console.WriteLine("������� ����� ������ ����� Enter:");
            this.side1 = double.Parse(Console.ReadLine());
            this.side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("������� ����:");
            this.angle = Math.PI*double.Parse(Console.ReadLine())/180.0;
            this.square = 0.5*side1*side2*Math.Sin(this.angle);
            Console.WriteLine("������� ������������: {0}", this.square);
            Console.WriteLine("��� ������ ������� 0/exit. ����� Enter.");
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