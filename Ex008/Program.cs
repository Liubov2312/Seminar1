﻿Console.WriteLine("enter the number");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < (N+1); i++)
{
if (i % 2 == 0) Console.Write($"{i} ");
}