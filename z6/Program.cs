//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да

int number1;

Console.WriteLine("Введите число ");
number1 = Convert.ToInt32(Console.ReadLine());
//если введеное число делится на 2 без остатка 
if (number1 % 2 == 0)
{
    Console.WriteLine($"{number1} -> да");
}
else
{
    Console.WriteLine($"{number1} -> нет");
}