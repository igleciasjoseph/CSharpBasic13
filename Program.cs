using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void PrintNumbers()
        {
            for(int i = 1; i < 256; i++) {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 1; i < 256; i+=2)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 1; i < 256; i++)
            {
                sum += i;
                Console.WriteLine(i);
                Console.WriteLine(sum);
            }
        }
        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine(i);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++){
                if (numbers[i] > max) {
                    max = numbers[i];
                }
            }
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i =0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            int avg = sum/numbers.Length;
        }
        public static int[] OddArray()
        {
            int[] array = new int[256];
            for (int i=1; i < array.Length; i+=2){
                Console.WriteLine(array[i]);
            }
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int sum = 0;
            for (int i=0; i < numbers.Length; i++){
                if (numbers[i] > y) {
                    sum ++;
                }
            }
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i =0; i < numbers.Length; i++) {
                numbers[i] = numbers[i] * numbers[i];
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i=0; i < numbers.Length; i++) {
                if (numbers[i] < 0) {
                    numbers[i] = 0;
                }
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > max) {
                    max = numbers[i];
                }
                if (numbers[i] < min) {
                    min = numbers[i];
                }
                sum += numbers[i];
                int avg = sum/numbers.Length;
            }
        }
        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++) {
                numbers[i] = numbers[i + 1];
                numbers[numbers.Length - 1] = 0;
            }
        }
        public static object[] NumToString(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++){
                if (numbers[i] < 0){
                    numbers[i].ToString("Dojo");
                }
            }
        }
    }
}
