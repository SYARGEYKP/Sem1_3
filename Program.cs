// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InputInt("Введите любое число");
if (a % 2 == 0)
{
    System.Console.WriteLine($"число чётное");
}
else
{
    System.Console.WriteLine($"число нечётное");
}