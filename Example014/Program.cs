﻿int[] arr = { 1, 5, 6, 3, 2, 5, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            {

            }
        }

        int tempotaty = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tempotaty;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
