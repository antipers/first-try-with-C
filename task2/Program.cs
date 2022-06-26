Console.WriteLine("введите число дня недели от 1 до 7");
int Week_day = Convert.ToInt32(Console.ReadLine());
if (Week_day == 1)
{
    Console.WriteLine("Mon");
}
else if (Week_day == 2)
{
    Console.WriteLine("Tue");
}
else if (Week_day == 3)
{
    Console.WriteLine("Wed");
}
else if (Week_day == 4)
{
    Console.WriteLine("Thu");
}
else if (Week_day == 5)
{
    Console.WriteLine("Fri");
}
else if (Week_day == 6)
{
    Console.WriteLine("Sun");
}
else if (Week_day == 7)
{
    Console.WriteLine("Sut");
}
else
{
    Console.WriteLine("Введите корректное число");
}