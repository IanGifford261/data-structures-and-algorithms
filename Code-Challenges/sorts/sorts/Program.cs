﻿using System;

namespace sorts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 7, 3, 5, 6 };

            //int[] result = InsertionSort(array);
            //int[] result = MergeSort(array);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
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

        /// <summary>
        /// Divides the array recursibely, merges the sub arrays
        /// </summary>
        /// <param name="arr"> the value for int[] </param>
        /// <returns></returns>
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            
            if (n > 1)
            {
                int mP = arr.Length / 2;

                int subLeftArrLength = mP + n;
                int subRightArrLength = mP - n;

                int[] subLeftArr = new int[subLeftArrLength];
                int[] subRightArr = new int[subRightArrLength];

                MergeSort(subLeftArr);
                MergeSort(subRightArr);

                Merge(subLeftArr, subRightArr, arr);
            }       
        }

        /// <summary>
        /// Merge algo that merges the sub arrays
        /// </summary>
        /// <param name="subLeftArr"></param>
        /// <param name="subRightArr"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Merge(int[] subLeftArr, int[] subRightArr, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < subLeftArr.Length && j < subRightArr.Length)
            {
                if (subLeftArr[i] <= subRightArr[j])
                {
                    arr[k] = subLeftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = subRightArr[j];
                    j++;
                }
                k++;
            }
            return arr;

        }

        /// <summary>
        /// QuickSort logic recursively on an array
        /// </summary>
        /// <param name="arr"> the value for int[] </param>
        /// <param name="left"> left element in array </param>
        /// <param name="right"> right element in array </param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);
                QuickSort(arr, left, position - 1);
                QuickSort(arr, position + 1, right);
            }
        }

        /// <summary>
        /// Partitions the array based of the declared pivot point
        /// </summary>
        /// <param name="arr"> the value for int[] </param>
        /// <param name="left"> left element in array </param>
        /// <param name="right"> right element in array </param>
        /// <returns></returns>
        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                    Swap(arr, right, low + 1);
                }
            }
            return low + 1;
        }

        /// <summary>
        /// swaps values in the array
        /// </summary>
        /// <param name="arr"> the value for int[] </param>
        /// <param name="i"> indec of input </param>
        /// <param name="low"> left of furthest left index pointer</param>
        public static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
