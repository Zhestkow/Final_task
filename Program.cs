// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами


using System;
using static System.Console;
Clear();

Write("Введите значения через пробел: ");
string[] Array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] ArrayResult = new string[GetNewArrayLength(Array)];
GetNewArray(Array, ArrayResult);
WriteLine($"[{string.Join(", ", Array)}]");
PrintNewArray(ArrayResult);




int GetNewArrayLength(string[] array)
{
    int idx = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            idx++;
        }
    }
    return idx;
}

string[] GetNewArray(string[] array, string[] array2)
{
    int idx = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[idx] = array[i];
            idx++;
        }
    }
    return array2;
}

void PrintNewArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}
