﻿
// Написать программу, которая из имеющегося массива строк, длина которых меньше либо равна 3 символа. Первоналаьный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// 1. Создать GitHub
// 2. Написать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (фаел README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать больше 4 коммитов

// ["hello", "2", "world", ":-)"]
// ["1234", "1567", "-2", "computer sciense"]
// ["Russia", "Denmark", "Kazan"]

Console.Clear();
int count = 0;
int count2 = 0;
Console.Write($"Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] arr = new string[n];

void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} значение массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
        if (array[i].Length <= 3) count++;
    }
}

InputArray(arr);

if (count == 0) { Console.WriteLine("Значений не найдено"); return; }

string[] arr2 = new string[count];

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j].Length <= 3) { arr2[count2] = arr[j]; count2++; }
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", arr)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", arr2)}]");