void printVar(int planesNumber) 

{
if (planesNumber == 1)
System.Console.WriteLine("x > 0 and y > 0");

else if (planesNumber == 2)
System.Console.WriteLine("x < 0 and y > 0");

else if (planesNumber == 3)
System.Console.WriteLine("x < 0 and y < 0");

else if (planesNumber == 4)
System.Console.WriteLine("x > 0 and y < 0");

else 
System.Console.WriteLine("Некорректные входные данные");
}

printVar(3);