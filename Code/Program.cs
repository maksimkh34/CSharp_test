string[] newStrArray(int arrayLength)
{
    string[] array = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


string[] getThreeDigitArray(string[] strArray)
{
    int length = strArray.Length;
    int counter = 0;
    for (int i = 0; i < length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            counter++;
        }
    }
    string[] newArray = new string[counter];
    counter = 0;
    for (int i = 0; i < length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            newArray[counter] = strArray[i];
            counter++;
        }
    }
    return newArray;
}

void printArray(string[] array)
{
    int length = array.Length;
    for (int i = 0; i < length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[length-1] + ". ");
    Console.WriteLine();
}

Console.Write("Введите длинну начального массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

string[] textArray = newStrArray(arrayLength);

string[] newArray = getThreeDigitArray(textArray);

Console.WriteLine();

printArray(newArray);