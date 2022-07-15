void triangle(int x, int y, int z)
{

    if (x + y > z && x + z > y && z + y > x) System.Console.WriteLine("triangle was born :)");
    else System.Console.WriteLine("triangle wasnt born :(");
}

triangle(3, 5, 4);

triangle(3, 5, 10);