using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ArrayHelper;
using RectangleHelper;

namespace M01
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = new int[5] { 5, 1, 3, 2, 4 };
            BubbleSort bubbleSort = new BubbleSort(arr, BubbleSort.SortOrder.Ascending);
            Console.WriteLine("Unsorted array:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            bubbleSort.Sort();

            Console.WriteLine('\n');
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine('\n');
            int[,] numbers =
            {
                { 1, 2, -3 },
                { 4, -5, 6 }
            };
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);

            Console.WriteLine("2D array:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            TwoDimArrSumBase abc = new TwoDimArrSumBase();
            Console.WriteLine("Sum of the all positive elements:");
            Console.WriteLine(abc.Sum(numbers));
            Console.Write("Enter a width of a rectangle >>");
            int wid = int.Parse(Console.ReadLine());
            Console.Write("Enter a hight of a rectangle >>");
            int hei = int.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(wid, hei);

            var results = new List<ValidationResult>();
            var context = new ValidationContext(rec);
            if (!Validator.TryValidateObject(rec, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Perimetr of a rectangle:");
                Console.WriteLine(rec.Perimetr());
                Console.WriteLine("Square of a rectangle");
                Console.WriteLine(rec.Square());
            }
        }
    }
}