// Вывод четных чисел от 1 до N
Console.Write("Введите число больше 1: ");
int number = int.Parse(Console.ReadLine());
while (number <=1) {
    Console.Write("Введено неверное число! Введите число больше 1: ");
    number = int.Parse(Console.ReadLine());
} 
int count = 2;
while (count <= number) {
    Console.Write(count + ", ");
    count +=2;
}
Console.Write("\b\b.");