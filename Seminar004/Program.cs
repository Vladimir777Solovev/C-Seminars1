// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Enter the number you want to raise to a power: ");
// double a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the degree to which you want to raise the number: ");
// double b = Convert.ToInt32(Console.ReadLine());
// double c = Math.Pow(a, b);
// Console.WriteLine($"Your number is: {c}");

// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int number = ReadInt("Enter your number: ");
// int len = NumberLen(number);
// SumNumbers(number, len);
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] arr = { 1, 2, 5, 7, 19, 6, 1, 33 };
// void PrintArray(int[] array)
// {
// int count = array.Length;
// for (int i = 0; i < count; i++)
// {
//   Console.Write($"{array[i]} ");
// }
//   Console.WriteLine();
// }
// PrintArray(arr);