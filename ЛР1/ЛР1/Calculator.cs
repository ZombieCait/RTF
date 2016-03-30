using System;
public class Calculator
{
    private string[] expression;
    private string[] result;
    private double answer;
    public Calculator()
    {
        Console.WriteLine("Программа может вычислять выражения с +, -, /, *. Введите выражение:");
    }
    public void InputExpression()
    {
        string expressionLine = Console.ReadLine().Replace('.', ',');
        if (expressionLine.IndexOf("/0") !=-1)
        {
            Console.WriteLine("Ошибка! На ноль делить нельзя.");
            return;
        }
        if(expressionLine.Length==0)
        {
            Console.WriteLine("Ошибка!Пустое выражение.");
            return;
        }

        string[] arithmetic = expressionLine.Split(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] expr = expressionLine.Split(new char[] { ' ', '+', '-', '/', '*' }, StringSplitOptions.RemoveEmptyEntries);
        this.expression = new string[expr.Length + expr.Length];
        for (int i = 0, j = 0; i < expr.Length; i++)
        {
            expression[j] = expr[i];
            j += 2;
        }
        if (arithmetic.Length == 0)
            return;
        for (int i = 0, j = 1; i < arithmetic.Length; i++)
        {
            expression[j] = arithmetic[i];
            j += 2;
        }
        this.CalculateSmth();
    }
    public void CalculateSmth()
    {
        result = new string[this.expression.Length];
        MultiplAndDivision();
        PlusAndMinus();
        Console.WriteLine(answer.ToString());
    }
    private void MultiplAndDivision()
    {
        for (int i = 0, j = 0; i < this.expression.Length - 1; i++)
        {
            if (expression[i].CompareTo("*") != 0 && expression[i].CompareTo("/") != 0)
            {
                this.result[j] = this.expression[i];
                j++;
            }
            else if (expression[i].CompareTo("*") == 0)
            {
                this.answer = (double.Parse(this.result[j - 1]) * double.Parse(this.expression[i + 1]));
                this.result[j - 1] = answer.ToString();
                i++;
            }
            else
            {
                answer = double.Parse(this.result[j - 1]) / double.Parse(this.expression[i + 1]);
                this.result[j - 1] = answer.ToString();
                i++;
            }
        }
    }
    private void PlusAndMinus()
    {
        for (int j = 0; j < this.result.Length - 1; j++)
        {
            if (result[j] == null)
                break;
            if (result[j].CompareTo("+") == 0)
            {
                answer = (double.Parse(this.result[j - 1]) + double.Parse(this.result[j + 1]));
                this.result[j + 1] = answer.ToString();
                j++;
            }
            if (result[j].CompareTo("-") == 0)
            {
                answer = double.Parse(this.result[j - 1]) - double.Parse(this.result[j + 1]);
                this.result[j + 1] = answer.ToString();
                j++;
            }
        }
    }
}
