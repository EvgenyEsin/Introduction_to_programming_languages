// Вывод max и min
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1>number2) Console.Write("Максимум: " + number1 + ", минимум: " + number2 + ".");
else Console.Write("Максимум: " + number2 + ", минимум: " + number1 + ".");