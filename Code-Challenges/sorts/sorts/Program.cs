﻿using System;

namespace sorts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Nate was debugging here
            int[] array = { 1, 7, 3, 5, 6 };
            int[] result = InsertionSort(array);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        /// <summary>
        /// Takes an array of integers, and returns a sorted array
        /// </summary>
        /// <param name="arr"> the value for int[] </param>
        /// <returns> a sorted int[] arr </returns>
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;

                }
                arr[j + 1] = temp;
            }
            return arr;
        }

        public static int[] MergeSort(int[] arr)
        {

        }
    }
}
