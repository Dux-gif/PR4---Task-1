using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4___Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());
            int sum = 0;
            int[,] arr = new int[row, col];

            Random r = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(10);
                    
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();


            }
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.Write($"Сумма всех элементов: {sum}");
            Console.ReadLine();
        }
    }
}
