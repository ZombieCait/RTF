using System;

namespace ��1
{
    class RandomNumbers
    {
        private int quantity;
        private int left;
        private int right;
        private int[] array;

      void GenerateNumbers()
        {
            if (right < left)
            {
                Console.WriteLine("������ �����, ������������ ������� ������ �����������.");
                return;
            }
            this.right++;
            this.array = new int[this.quantity];
            Random rand = new Random();
            for (int i = 0; i < this.quantity; i++)
                array[i] = rand.Next(this.left, this.right);
        }

        void GetAnalysGenerateNumbers()
        {
            int countNumber = 0;
            for (int i = left; i < this.right; i++)
            {
                for (int j = 0; j < this.quantity; j++)
                {
                    if (this.array[j] == i)
                        countNumber++;
                }
                if (countNumber > 0)
                {
                    Console.WriteLine("����� {0} ������������� {1} ", i, countNumber);
                }
                countNumber = 0;
            }
        }

        public void AnalyzeRandomlyNumbers()
        {
            Console.WriteLine("������� ���������� �������� �����:");
            this.quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("������� ����������� �������:");
            this.left = int.Parse(Console.ReadLine());
            Console.WriteLine("������� ������������ �������:");
            this.right = int.Parse(Console.ReadLine());
            GenerateNumbers();
            GetAnalysGenerateNumbers();
        }
    }
}