﻿int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int max = 0;

if (a > b)
{
    max = a;

}
else
{
    max = b;
}

Console.Write("Большее введенное число >>> ");    
Console.WriteLine(max);