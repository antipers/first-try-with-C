/* Первый вариант из лекции
 int[] array = new int[8];

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write(col[position] + " ");
        position++;
    }
}


FillArray(array);
PrintArray(array); 

Второй вариант из семинара*/


int[] array = new int[8];

void FillArrayByRandom(int[] ArrRandom)
{
    for (int index = 0; index < ArrRandom.Length; index++)
    {
        ArrRandom[index] = new Random().Next(2);
    }
}

void PrintArray(int[] ArrRandom)
{
    foreach (var item in ArrRandom)
    {
        System.Console.Write(item + " ");
    }
}


FillArrayByRandom(array);
PrintArray(array);