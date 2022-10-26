Console.SetCursorPosition(35, 0);

while (true)
{
    Console.WriteLine("Выберите программу, которую хотите запустить");
    Console.WriteLine("1. Угадай число");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Выход из программы");

    int input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        random();
    }



    

    else if (input == 2)
    {
        table();
    }



    else if (input == 3)
    {
        vivod();
    }


    else if (input == 4)
    {
        break;
    }

 
}
static void random()




{
    Console.WriteLine("Угадайте число");
    Random rnd = new Random();
    int slo = rnd.Next(0, 100);
    int polz = Convert.ToInt32(Console.ReadLine());

    do
    {
        if (polz > slo)
        {
            Console.WriteLine("Пониже)");
            polz = Convert.ToInt32(Console.ReadLine());

        }

        if (polz < slo)
        {
            Console.WriteLine("Повыше)");
            polz = Convert.ToInt32(Console.ReadLine());
        }

        if (polz == slo)
        {
            Console.WriteLine("Вы угадали!, это число " + slo);
        }

    } while (polz != slo);
}
static void table()
{
    Console.WriteLine("Таблица  умножения:");
    int[,] a = new int[10, 10];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        a[i, 0] = i + 1;

        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = (j + 1) * (i + 1);
            Console.Write(a[i, j] + "\t");

        }
        Console.WriteLine();
    }
}
static void vivod()
{
    Console.WriteLine("Если хотите выйти, напишите \"выйти\"");
    Console.WriteLine("Вывод делитилей числа");
    Console.WriteLine("Введите число");
    int number1 = Convert.ToInt32(Console.ReadLine());

    for (int a = 1; a <= number1; a++)
    {
        if (number1 % a == 0) Console.Write("{0} ", a);
    }

}

