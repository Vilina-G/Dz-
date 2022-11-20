// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
int number1;
int number2;

Console.WriteLine("Введите число 1");
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} > {number2}");
}

if (number1 < number2)
{
    Console.WriteLine($"{number1} < {number2}");
}


