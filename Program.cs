string[] StageSelection(int index)
{
    switch (index)
    {
        case 1:

            Console.WriteLine("Тестовый массив: ");
            string[] temp1 = { "ABSD", "123", "GB", "покемон", " ^$^", "#@#" };

            Console.WriteLine($"[ {string.Join(", ", temp1)} ] ");

            return temp1;

        case 2:

            Console.WriteLine("Введите строки через пробел: ");

            string? test = Convert.ToString(Console.ReadLine());
            string[] temp2 = test.Split(new char[] { ' ' });

            Console.WriteLine();
            Console.WriteLine("Введеный массив: ");
            Console.WriteLine($"[ {string.Join(", ", temp2)} ] ");

            return temp2;

        default:

            string[] temp = { " " };
            return temp;
    }
}

string[] StringRangeFilter(string[] temp, int range)
{

    int size = 0;
    string bufer = "";

    for (int i = 0; i < temp.Length; i++)
    {
        size = temp[i].Length;

        if (size < range + 1) bufer += temp[i] + " ";
    }

    bufer = bufer.Trim(new char[] { ' ' });

    string[] result = bufer.Split(new char[] { ' ' });

    return result;

}

Console.WriteLine("Включить тестовую работу - 1");
Console.WriteLine("Включить ручной ввод - 2");
Console.Write("Введите команду: ");

string? valve = Convert.ToString(Console.ReadLine());

if (valve == "1" || valve == "2") // Защита от неправильного ввода
{
    int number = Convert.ToInt32(valve);
    string[] sortikol = StageSelection(number);
    int size = 3;// указан необходимый размер фильтрации символов + 1 

    sortikol = StringRangeFilter(sortikol, size);

    Console.WriteLine();
    Console.WriteLine("Отфильтрованый массив: ");
    Console.WriteLine($"[ {string.Join(", ", sortikol)} ] ");
}
else
{
    Console.WriteLine("Неправильный ввод!");
}



