using System;

namespace ЛР1
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
                Console.WriteLine("Ошибка ввода, максимальная граница больше минимальной.");
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
                    Console.WriteLine("Число {0} сгенерировано {1} ", i, countNumber);
                }
                countNumber = 0;
            }
        }

        public void AnalyzeRandomlyNumbers()
        {
            Console.WriteLine("Введите количество генераци числа:");
            this.quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальную границу:");
            this.left = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную границу:");
            this.right = int.Parse(Console.ReadLine());
            GenerateNumbers();
            GetAnalysGenerateNumbers();
        }
    }
}