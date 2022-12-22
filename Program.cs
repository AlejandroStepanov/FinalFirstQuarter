// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//   лучше обойтись исключительно массивами.

Console.Clear();


string[] array = new string[5] {"Море", "солнце", "буй", "яхта", "меч"};
string[] arrayNew = new string[array.Length];

void arrayNewLimit(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3) //Ограничение длинны
        {
        array2[j] = array1[i];
        j++;
        }
    }
}

void PrintArray(string[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
    Console.WriteLine();
}

arrayNewLimit(array, arrayNew);

PrintArray(arrayNew);