
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
int ArrayLength = 0;
int count = 0;
Console.Write($"Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] Array = new string[n];

void InputArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Введите {i + 1} значение массива: ");
        Array[i] = Convert.ToString(Console.ReadLine());
        if (Array[i].Length <= 3) ArrayLength++;
    }
}

void InputArray2(string[] FinalArray, string[] Array)
{
    for (int j = 0; j < Array.Length; j++)
    {
        if (Array[j].Length <= 3) { FinalArray[count] = Array[j]; count++; }
    }
}

InputArray(Array);
string[] FinalArray = new string[ArrayLength];
if (ArrayLength == 0) { Console.WriteLine("Значений не найдено"); return; }
InputArray2(FinalArray, Array);

Console.WriteLine($"Начальный массив: [{string.Join(", ", Array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", FinalArray)}]");