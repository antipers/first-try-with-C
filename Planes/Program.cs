/* int getPlanesNumber(float x, float y)
{
    if (x>0 && y>0)
    return 1;

    if (x<0 && y>0)
    return 2;

    if (x>0 && y<0)
    return 3;

    if (x>0 && y<0)
    return 4;

    return -1;
}

System.Console.WriteLine();
int planesNumber = getPlanesNumber(-1,2);
if (planesNumber != -1)
System.Console.WriteLine($"Плоскость {planesNumber}");
else
System.Console.WriteLine("Некорректные данные");


 */


void printPlanesNumber(float x, float y)
{
    if (x > 0 && y > 0)
        System.Console.WriteLine("Плоскость 1");

    else if (x < 0 && y > 0)
        System.Console.WriteLine("Плоскость 2");

   else if (x < 0 && y < 0)
        System.Console.WriteLine("Плоскость 3");

    else if (x > 0 && y < 0)
        System.Console.WriteLine("Плоскость 4");

    else
    {
        System.Console.WriteLine("Некорректные входные данные");
    }
}
printPlanesNumber(2, 2);