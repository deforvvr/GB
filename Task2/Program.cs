int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = 0;

if (a > b)
{
    max = a;

}
else
{
    max = b;
}

if (max > c)
{
    Console.Write("Самое большое число >>> ");
    Console.WriteLine(max);
}
else
{
    max = c;
    Console.Write("Самое большое число >>> ");
    Console.WriteLine(max);
}
