// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// задача с целыми числами.
// Console.Clear();
// Console.WriteLine("Ведите число А:   ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ведите число B:   ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"{a} в степени {b} -> {Math.Pow(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// int SumNums(int n)
// {
//     int sum = 0;
//     for (int i = 0; i <= Math.Abs(n % 10); i++)
//     {
//         n = n % 10;
//         sum += i;
//     }
//     return sum;
// }
// Console.Clear();
// Console.WriteLine("Введите число:  ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр = {SumNums(num)}");




//if (number > 9999 && number < 100000)
// {
//     if (number/ 10000 == (number) % 10 && (number % 10000 - number % 1000) / 1000 == (number % 100 - number % 10) / 10)
//     {
//         Console.WriteLine($"{number} <- Число Полиндром");
//     }

//     else
//     {
//         Console.WriteLine("Данное число не полиндром!");
//     }
// }
// else
// {
//     Console.WriteLine("Введите пятизначное число:  !");
// }

// while (number < 10000 || number > 99999)
// {
//     int number1 = Convert.ToInt32(Console.ReadLine());
//     if (number1 < 10000 || number1 > 99999)
//     {
//         Console.WriteLine("Введите пятизначное число!");
//     }
//     else
//     {
//         if ((number1 - number1 % 10000) / 10000 == (number1) % 10 && (number1 % 10000 - number1 % 1000) / 1000 == (number1 % 100 - number1 % 10) / 10)
//         {
//             Console.WriteLine($"{number1} <- Число Полиндром");
//             return;
//         }

//         else
//         {
//             Console.WriteLine("Данное число не полиндром!");
//             return;
//         }
//     }
// }
