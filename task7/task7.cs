// Принимаем два числа
// Является ли одно число квадратом другого

// int num1 = 25;
// int num2 = 5;

int num1 = new Random().Next(1, 101);
int num2 = new Random().Next(1, 101);

Console.WriteLine("Является ли одно число квадратом другого?");
Console.Write("Первое число: " + num1);
Console.WriteLine(", Второе число: " + num2);


if (num1 * num1 == num2)
{
    Console.WriteLine("Ответ: Первое число является квадратом другого");
}
else
{
    if (num2 * num2 == num1)
    {
        Console.WriteLine("Ответ: Второе число является квадратом другого");
    }
    else
    {
        Console.WriteLine("Ответ: Ни одно число не является квадратом другого");
    }
}