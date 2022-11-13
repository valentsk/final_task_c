Console.Clear();

Console.Write("Введи размерность массива: ");
string[] arrayInit = CreateArray();

Console.WriteLine("Введите символы, строки через Enter для заполнения массива:");
FillArray(arrayInit);
Console.Write("Начальный массив:");
PrintArray(arrayInit);
int newSize = CheckNewSize(arrayInit);
string[] arrayFinal = CreateArrayThreeSymbols(newSize);
FillArrayThreeSymbols(arrayInit, arrayFinal);
Console.Write("Конечный массив:");
PrintArray(arrayFinal);


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
    Console.WriteLine("['" + string.Join("', '", array) + "']");
}

int CheckNewSize(string[] array)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newSize++;
        }
    }
    return newSize;
}

string[] CreateArrayThreeSymbols(int size)
{
    string[] array = new string[size];
    return array;
}

void FillArrayThreeSymbols(string[] arrayStart, string[] arrayFinal)
{
    int j = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
        if (arrayStart[i].Length <= 3)
        {
            arrayFinal[j] = arrayStart[i];
            j++;
        }
    }
}