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
        System.Console.WriteLine("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

