// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7

int number1;
int number2;
int number3;
int max;

Console.WriteLine("Введите число 1");
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3");
number3 = Convert.ToInt32(Console.ReadLine());
// назначаем переменной max значение 1
max = number1;
// если max меньше значения 2 то выполняем условие 
if (max < number2)
{
    // назначаем переменной max значение 2
    max = number2;
}
// если max меньше значения 3 то выполняем условие 
if (max < number3)
{
    // назначаем переменной max значение 3
    max = number3;
}
Console.WriteLine($"{max}");