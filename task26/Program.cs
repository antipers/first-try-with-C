/* int n = 123;
int digitCount = (int)Math.Log10(n) + 1;
System.Console.WriteLine(digitCount);
 */

int number = 12345;
int count = 0;
for (; number != 0; number /= 10)
{
    count++;
}
System.Console.WriteLine(count);