/* Console.WriteLine("Введите координаты А ");
int AX = Convert.ToInt32(Console.ReadLine());
int AY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты B ");
int BX = Convert.ToInt32(Console.ReadLine());
int BY = Convert.ToInt32(Console.ReadLine());

int dX = AX - BX;
int dY = AY - BY;



Double rangeC = Math.Sqrt(dX * dX + dY * dY);
System.Console.WriteLine(rangeC); */

void printGipo(double aX, double aY, double bX, double bY)
{
    double dX = aX - bX;
    double dY = aY - bY;
    double rangeC = Math.Sqrt(dX * dX + dY * dY);
    System.Console.WriteLine(rangeC);
}

printGipo(4, 3, 5, 6);