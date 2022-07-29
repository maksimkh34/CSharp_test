string[] newStrArray(int arrayLength)
{
    string[] array = new string[arrayLength];
    for(int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

Console.Write("Введите длинну начального массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

string[] textArray = newStrArray(arrayLength);

