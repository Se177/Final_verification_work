// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.


string[] matrix = CreateArray();
string[] CreateArray()
{
    Console.WriteLine("Введите значения строк массива через пробел: ");
    string? enterStringSymb = Console.ReadLine();
    if (enterStringSymb == null) { enterStringSymb = ""; };
    char[] sep = new char[] { ',', ' ' };
    string[] matrix = enterStringSymb.Split(sep, StringSplitOptions.RemoveEmptyEntries);
    return matrix;
}

int CalcStringSymb(string[] matrix)
{
    int counter = 0;
    foreach (string item in matrix)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] getArray = CreateNewArray(matrix);
string[] CreateNewArray(string[] matrix)
{
    int getArrayLength = CalcStringSymb(matrix);
    string[] getArray = new string[getArrayLength];
    int i = 0;
    foreach (string item in matrix)
    {
        if (item.Length <= 3)
        {
            getArray[i] = item;
            i++;
        }
    }
    return getArray;
}

string startingArray = PrintArray(matrix);
string resultArray = PrintArray(getArray);
string PrintArray(string[] matrix)
{
    string stringArray = "[";
    for (int i = 0; i < matrix.Length; i++)
    {
        if (i == matrix.Length - 1)
        {
            stringArray += $"\"{matrix[i]}\"";
            break;
        }
        stringArray += ($"\"{matrix[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

Console.WriteLine($"Исходный массив: {startingArray}");
Console.WriteLine($"Полученный массив: {resultArray}");

