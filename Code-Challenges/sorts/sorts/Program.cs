﻿using System;

namespace sorts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 7 };
            InsertionSort(array);

        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[i])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
    }
}
