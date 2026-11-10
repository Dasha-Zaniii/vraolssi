//1

Console.Write("Введите температуру в Цельсиях: ");
int c = int.Parse(Console.ReadLine());
int f = c * 9 / 5 + 32;
Console.WriteLine($"Температура в Фаренгейтах: {f}");

//2

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c2 = int.Parse(Console.ReadLine());
int avg = (a + b + c2) / 3;
Console.WriteLine($"Среднее арифметическое: {avg}");

//3

Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма: {x + y}");
Console.WriteLine($"Разность: {x - y}");
Console.WriteLine($"Произведение: {x * y}");
Console.WriteLine($"Частное: {x / y}");

