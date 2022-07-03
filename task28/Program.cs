Console.WriteLine("Введите число");
int factor = int.Parse(Console.ReadLine());

int GetSumFast(int factor)
{
    int factorial=1;
    for (int i = 1; i <= factor; i++)

    {
        factorial = factorial * i;

    }
    return factorial;
}
Console.WriteLine(GetSumFast(factor));