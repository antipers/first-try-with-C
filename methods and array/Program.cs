int[] array = { 88, 24, 35, 84, 15, 46, 79, 88, 59 };
int n = array.Length;
int find = 88;
int index = 0;
while (index < n)
{
if (array[index] == find)
{
    System.Console.WriteLine(index);
    //break; - if need only first result
}
index++;
}