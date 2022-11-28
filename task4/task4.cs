// Выводим случайное трехзначное число
// Выводим число без второй цифры

int num = new Random().Next(100, 1000);

int num1 = num / 100;

int num2 = (num / 10) % 10;

int num3 = num % 10;

Console.WriteLine("Случайное трехзначное число: " + num);
Console.Write ("Введеное число без второй цифры: ");
Console.Write(num1);
Console.Write(num3);

// Решено