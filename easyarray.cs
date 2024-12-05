using System;

int[] zahlen = {5, 3232, 112, 3, 89, 99999, 1, 33333, 2147483647, 111111, 3003, 264};
int input;

Console.Write($"Eine Zahl [0-11]:");
input = int.Parse(Console.ReadLine());
Console.WriteLine($"Eine andere Zahl: {zahlen[(input)]}");