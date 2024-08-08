using System;
using System.Collections;

namespace Number_q
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {1, 2, 3, 4, 5,};

            Console.WriteLine("Original Array");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            DoubleArrayValues(numbers);

            Console.WriteLine("\nArray setelah nilai digandakan:");
            foreach (var number in numbers)
            {
            Console.Write(number + " ");   
            }
            Console.WriteLine();
        }

        static unsafe void DoubleArrayValues(int[] array)
        {
            fixed (int* ptr = array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    *(ptr + i) *= 2;
                }
            }
        }
    }
}
