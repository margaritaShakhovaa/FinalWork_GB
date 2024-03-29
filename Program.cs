﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Clear();

void FillArray(string[] array)
{
    Console.WriteLine("Введите любые 5 комбинаций из букв или чисел через Enter:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

string[] FillNewArray(string[] array)
{
    int newarraylength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarraylength++;
        }
    }

    string[] newarray = new string [newarraylength];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

void Demo ()
{
    string[] array = new string[5];
    FillArray(array);
    Console.WriteLine("");
    PrintArray(FillNewArray(array));
}

Demo ();