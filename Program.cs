// 1. Напишите программу, кот-я на вход принимает два числа и выдаёт, какое число больше, а какое меньше
// Console.Write("Введите первое число: ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// if (numb1 >= numb2)
// {
//     Console.Write("max = ");
//     Console.WriteLine(numb1);
// }
// else
// {
// Console.Write("max = ");
// Console.WriteLine(numb2);
// }   

// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Write("Введите первое число: ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int numb3 = Convert.ToInt32(Console.ReadLine());
// if (numb1 > numb2 && numb1 > numb3)
//     Console.WriteLine(numb1);
// else if (numb2 >= numb1 && numb2 >= numb3)
//     Console.WriteLine(numb2);
// else (numb3 > numb1 && numb3 > numb2)
//     Console.WriteLine(numb3);

// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Введите первое число: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// if (numb % 2 == 0)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");

4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < n)
{
    if (count == n - 2)
        System.Console.Write($"{count}");
    else if (count % 2 == 0)
        System.Console.Write($"{count},");
    count++;
}