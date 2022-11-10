using System;
using static System.Console;
Clear();

Write("Введите значения через пробел: ");
string[] Array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
PrintNewArray(Array);




void PrintNewArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}
