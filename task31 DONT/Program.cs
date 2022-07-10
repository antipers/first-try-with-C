/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
 */

// Version 1.0 with 2 methods
//int SumPositiveNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sum += array[i];
//         }

//     }
//     return sum;
// }

// int SumNegativeNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sum += array[i];
//         }

//     }
//     return sum;
// }

int SumNumbersParametric(int[] array, bool findPositiveNumbers = true)
{
    int sum = 0;
    foreach (int elements in array)
    {
        if (findPositiveNumbers)
        {
            sum += elements > 0 ? elements : 0;
        }
        else
        {
            sum += elements < 0 ? elements : 0;
        }
    }
    return sum;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
  System.Console.Write(string.Join(", ", array));
}



int[] array = GetArray(12, -9, 9);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(SumNumbersParametric(array, true));
System.Console.WriteLine();
System.Console.WriteLine(SumNumbersParametric(array, false));