using System;

namespace ЛР1
{

    class Program
    {
        static void shellSort(int[] mass)
        {
            int step = mass.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < mass.Length; i++)
                {
                    int value = mass[i];
                    for (j = i - step; (j >= 0) && (mass[j] > value); j -= step)
                        mass[j + step] = mass[j];
                    mass[j + step] = value;
                }
                step /= 2;
            }

        }

        static void IsInt(out int test)
        {
            while (!int.TryParse(Console.ReadLine(), out test))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив:");
            string s = Console.ReadLine();
            string[] num = s.Split(' ');
            int[] numbers = new int[num.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(num[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Нажмите Enter, что бы начать сортировку");
            Console.ReadLine();
            shellSort(numbers);
            Console.WriteLine("Готово! Теперь ваш массив выглядит следующим образом:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}