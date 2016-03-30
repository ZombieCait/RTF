using System;
using System.Collections.Generic;

public class Matrix
{
    private List<List<int>> matrix = new List<List<int>>();
    private int n;

    public Matrix() 
    {
        Console.WriteLine("Введите размерность матрицы:");
        this.n = int.Parse(Console.ReadLine());
        var rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            List<int> row = new List<int>();
            for (int j = 0; j < n; j++) 
                row.Add(rnd.Next(0, 100));
            matrix.Add(row); 
        }
    }

    public void Replace()
    {
        
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < this.n; i++)                    
        {
            for (int j = 0; j < this.n; j++)
                Console.Write(this.matrix[i][j] + " ");
            Console.WriteLine();
        }
        for (int j = 0; j < this.n; j++)
        {
            int maxElement = 0;
            int row = 0;
            for (int i = 0; i < this.n; i++)
            {
                if (this.matrix[i][j] > maxElement)
                {
                    maxElement = matrix[i][j];
                    row = i;
                }
            }
            matrix[row][j] = matrix[j][j];
            matrix[j][j] = maxElement;
        }
        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < this.n; i++)
        {
            for (int j = 0; j < this.n; j++)
                Console.Write(this.matrix[i][j] + " ");
            Console.WriteLine();
        }
    }
}