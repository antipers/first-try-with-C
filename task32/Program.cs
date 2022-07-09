/* Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
 */

 int[] array = {-4, -8, 8, 2};

//  void PrintArray(int[] array)
//  {
//     for (int i = 0; i < array.Length; i++)
//     {
//       System.Console.Write($"{array[i]} / ");
//     }
//  }

 void changeArray(int[] array)
 {
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i]*-1;
    System.Console.Write($"{array[i]} / ");
}
 }
changeArray(array);