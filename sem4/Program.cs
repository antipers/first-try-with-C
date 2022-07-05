int sum = 0;
            
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetSum(num));
Console.WriteLine(GetSumFast(num));


int GetSum(int a) 
{
    sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

int GetSumFast(int a)
{
    return a * (a + 1) / 2;
}
