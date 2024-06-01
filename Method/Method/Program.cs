using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = GenerateNumbers(10);
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        // Generate
        static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i + 1;
            }

            return numbers;
        }

        // Reverse
        static void Reverse(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }
        }

        // print
        static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}    