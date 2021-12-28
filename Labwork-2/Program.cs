using System;

namespace Labwork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] myArray = new int[n, m];
            int startNum = n * m;

            int offset_0 = 0;
            int offset_1 = 1;
            int offset_2 = 2;
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            /*for (int x = width - 1; x >= width - (width - 0); x--)
            {
                myArray[height - (height - 0), x] = startNum;
                startNum--;
            }
        
            for (int y = height - (height - 1); y <= height - 1; y++)
            {
                myArray[y, width - (width - 0)] = startNum;
                startNum--;
            }

            for (int x = width - (width - 1); x <= width - 1; x++)
            {
                myArray[height - 1, x] = startNum;
                startNum--;
            }

            for (int y = height - 2; y >= height - (height - 1); y--)
            {
                myArray[y, width - 1] = startNum;
                startNum--;
            }

            // ----------------------------

            for (int x = width - 2; x >= width - (width - 1); x--)
            {
                myArray[height - (height - 1), x] = startNum;
                startNum--;
            }

            for (int y = height - (height - 2); y <= height - 2; y++)
            {
                myArray[y, width - (width - 1)] = startNum;
                startNum--;
            }

            for (int x = width - (width - 2); x <= width - 2; x++)
            {
                myArray[height - 2, x] = startNum;
                startNum--;
            }

            for (int y = height - 3; y >= height - (height - 2); y--)
            {
                myArray[y, width - 2] = startNum;
                startNum--;
            }*/


            while (startNum > 0)
            {
                for (int x = width - offset_1; x >= width - (width - offset_0); x--)
                {
                    myArray[height - (height - offset_0), x] = startNum;
                    startNum--;
                    if (startNum <= 0)
                    {

                    }
                }
                if (startNum <= 0)
                {
                    break;
                }

                for (int y = height - (height - offset_1); y <= height - offset_1; y++)
                {
                    myArray[y, width - (width - offset_0)] = startNum;
                    startNum--;
                }
                if (startNum <= 0)
                {
                    break;
                }

                for (int x = width - (width - offset_1); x <= width - offset_1; x++)
                {
                    myArray[height - offset_1, x] = startNum;
                    startNum--;
                }
                if (startNum <= 0)
                {
                    break;
                }

                for (int y = height - offset_2; y >= height - (height - offset_1); y--)
                {
                    myArray[y, width - offset_1] = startNum;
                    startNum--;
                }
                if (startNum <= 0)
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
