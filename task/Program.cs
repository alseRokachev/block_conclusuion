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

