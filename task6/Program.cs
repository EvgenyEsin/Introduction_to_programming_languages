// Вывод является ли число четным
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) {
    Console.Write("Число " + number + " - четное");
}
else {
    Console.Write("Число " + number + " - нечетное");
}