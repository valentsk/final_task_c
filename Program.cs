Console.Clear();

Console.Write("Введи размерность массива: ");
string[] array = CreateArray();

Console.WriteLine("Введите символы, строки через Enter для заполнения массива:");
FillArray(array);
Console.Write("Конечный массив:");
PrintArray(array);


string[] CreateArray()
{
    int size = int.Parse(Console.ReadLine()!);
    string[] array = new string[size];
    return array;
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

