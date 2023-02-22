int numbCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write("Введите длину массива: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            return number;
        }
        System.Console.WriteLine("Некорректно введены данные");
    }
}

string[] fillArrWithElement()
{
    int arrLength = numbCheck("Введите длину массива: ");
    string[] array = new string[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        System.Console.Write("Введите элемент массива: ");
        string temp = Console.ReadLine();
        if (temp == string.Empty)
        {
            System.Console.WriteLine("Нельзя оставить этот элемент пустым");
            System.Console.WriteLine();
            i--;
        }
        else
        {
            array[i] = temp;
        }
    }
    return array;
}

int findSortedArrLength(string[] refArray)
{
    int counter = 0;
    for (int i = 0; i < refArray.Length; i++)
    {
        if (refArray[i].Length < 4)
        {
            counter++;
        }
    }
    return counter;
}

string[] sortArr(string[] refArray, int sortedArrLength)
{
    int counter = 0;
    string[] array = new string[sortedArrLength];
    for (int i = 0; i < refArray.Length; i++)
    {
        if (refArray[i].Length > 3)
        {
            continue;
        }
        else
        {
            array[counter] = refArray[i];
            counter++;
        }
    }
    return array;
}

void printArray(string[] sortedArray)
{
    if (sortedArray.Length == 1)
    {
        System.Console.WriteLine("Элементы, чья длина меньше 3-х символов отсутствуют");
    }
    else
    {
        System.Console.WriteLine($"Элементы, чья длина меньше или равна 3-м символам: {String.Join(" , ", sortedArray)}");
    }
}

string[] refArray = fillArrWithElement();
int sortedArrLength = findSortedArrLength(refArray);
string[] sortedArray = sortArr(refArray, sortedArrLength);
printArray(sortedArray);