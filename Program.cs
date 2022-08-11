int a = new Random().Next(1,10);
Console.WriteLine("Первое число: "+a);
int b = new Random().Next(1,10);
Console.WriteLine("Второе число: "+b);
int c = new Random().Next(1,10);
Console.WriteLine("Третье число: "+c);
if (a > b )
{
    Console.WriteLine("Самое большое число из a и b: "+a);
}
else 
{
    Console.WriteLine("Самое большое число из a и b: "+b);
}
if (a > c)
{
    Console.WriteLine("Самое большое число из a и c: "+a);
}
else
{
    Console.WriteLine("Самое большое число из a и b: "+c);
}
if (b > c)
{
    Console.WriteLine("Самое большое число из a и b: "+b);
}
else
{
    Console.WriteLine("Самое большое число из a и b: "+c);
}