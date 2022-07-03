/* System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("___");
int line = 0;
if (num > 0)
{
    while (line < num)
    {
        Console.WriteLine($"{line * line}");
        line++;
    }
}
else
{
    while (line > num)
    {
        Console.WriteLine($"{line * line}");
        line--;
    }
} */



void getSquare(int num)
{
    if (num > 0)
    {
        for (int line = 0; line < num; line++)
        {
            Console.Write($"{line * line}" + " ");
        }
    }
    else if (num < 0)
    {
        for (int line = 0; line > num; line--)
        {
            Console.Write($"{line * line}" + " ");
        }
    }
else System.Console.WriteLine("Некорректные входные данные");
}
System.Console.WriteLine("введите число");
getSquare(Convert.ToInt32(Console.ReadLine()));