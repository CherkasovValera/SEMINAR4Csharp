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


int SumNums(int n)
{
    int sum = 0;
    int i = 0;
    while (i <= Math.Abs(n * 10))
    {
        sum = sum + Math.Abs(n) % 10;
        n = n / 10;
        i++;
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите число:  ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {SumNums(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// void FillArray(int[] massiv)
// {
//     int length = massiv.Length;
//     int index = 0;
//     while (index < length)
//     {
//         massiv[index] = new Random().Next(1, 10);
//         index++;
//     }

// }
// void PrintArray(int[] mass)
// {
//     int count = mass.Length;
//     int position = 0;
//     Console.Write("[");
//     while (position < count)
//     {
//         Console.Write($"{mass[position]} ");
//         position++;
//     }
//     Console.Write("]");
// }
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);

