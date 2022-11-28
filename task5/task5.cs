// Принимаем два числа
// Вычислить является ли второе число кратное первому
// Иначе провести остаток от деления

int num1 = new Random().Next(1,101);

int num2 = new Random().Next(1, 11);

Console.Write("Первое число: " + num1);

Console.WriteLine(", Второе число: " + num2);

int num3 = num1 / num2;

if (num2 * num3 == num1)
{
    Console.WriteLine("Второе число кратное первому");
}
else
{
    int per = num1 % num2;
    Console.WriteLine("Второе число не кратно, остаток: " + per);
}

// Решено