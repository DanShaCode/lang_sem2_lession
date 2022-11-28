// Принимаем на вход число
// Кратно ли это число одновременно 7 и 23

int num = 46;

// int num = new Random().Next(100, 1000);

Console.WriteLine("Является ли введеное число одновременно кратно 7 и 23?");
Console.WriteLine("Сгенерированное число: " + num);

int num2 = 7;

int num3 = 23;

int resnum2 = num / num2;

if (resnum2 * num2 == num)
{
    int resnum3 = num / num3;
    if (resnum3 * num3 == num)
    {
        Console.WriteLine("Ответ: Да");
    }
    else
    {
        Console.WriteLine("Ответ: Нет");
    }
}

if (resnum2 * num2 != num)
{
    Console.WriteLine("Ответ: Нет");
}


