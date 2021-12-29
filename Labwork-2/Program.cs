using System;

namespace Labwork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входные данные
            Console.Write("Введите первое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] myArray = new int[n, m]; // Создание двумерного массива на основе введённых данных
            int currentValue = n * m; // Стартовое число (Самое верхнее правое число при выводе массива)

            int offset_0 = 0; 
            int offset_1 = 1; // Оффсеты - числа, увеличивающие своё значение с каждой итерацией цикла while (startNum > 0). Необходимы для постепенного "сужения" к центру массива при выводе его в виде спирали.
            int offset_2 = 2;
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            while (currentValue > 0)
            {
                for (int x = width - offset_1; x >= width - (width - offset_0); x--)
                {
                    myArray[height - (height - offset_0), x] = currentValue;
                    currentValue--;
                }
                if (currentValue <= 0)
                {
                    break;
                }

                for (int y = height - (height - offset_1); y <= height - offset_1; y++)
                {
                    myArray[y, width - (width - offset_0)] = currentValue;
                    currentValue--;
                }
                if (currentValue <= 0)
                {
                    break;
                }

                for (int x = width - (width - offset_1); x <= width - offset_1; x++)
                {
                    myArray[height - offset_1, x] = currentValue;
                    currentValue--;
                }
                if (currentValue <= 0)
                {
                    break;
                }

                for (int y = height - offset_2; y >= height - (height - offset_1); y--)
                {
                    myArray[y, width - offset_1] = currentValue;
                    currentValue--;
                }
                if (currentValue <= 0)
                {
                    break;
                }

                offset_0++;
                offset_1++;
                offset_2++;
            }

            // Вывод Массива
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
