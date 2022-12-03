// // Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int ReadDataInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string ReadDataStr(string message)
{
    Console.WriteLine(message);
    string word = Console.ReadLine();
    if (string.IsNullOrEmpty(word)) throw new Exception("Вы не ввели число, введите его, пожалуйста");
    else return word;

}

string? ReadData(string message)
{
    while(true)
    {
        try
        {
            return ReadDataStr(message);
        }
        catch(Exception e)
        {
            Console.WriteLine($"Вы что-то не правильно ввели", e.Message);
        }
    }
}

void PrintArray(string[] array, string message)
{
    Console.WriteLine(message);
    foreach (string item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

string[]? CreateArray(int number)
{
    string[] array = new string[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadData($"Введите {i + 1}-й элемент массива");
    }
    return array;
}

int CounterForNewArray(string[] array)
{
    int counter = 0;
    foreach (string item in array)
    {
        if (item.Length < 4) counter++;
    }
    return counter;
}

string[] GetNewArray(string[] array, int counter)
{
    string[] newArray = new string[counter];
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length < 4)
        {
            newArray[i] = item;
            i++;
        }
    }
    return newArray;
}

void Main()
{
    int lengthOfFirstArray = ReadDataInt("Введите размер массива для заполнения");
    string[] stringArray = CreateArray(lengthOfFirstArray);
    PrintArray(stringArray, "Введенный массив:");
    int lengthOfNewArray = CounterForNewArray(stringArray);
    string[] newStringArray = GetNewArray(stringArray, lengthOfNewArray);
    PrintArray(newStringArray, "Массив из элементов, длина которых <= 3:");
}

Main();