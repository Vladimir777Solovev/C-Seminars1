// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите число: ");
// string a = Console.ReadLine();
// int b = a.Length;

// if (b == 5)
// {
//     if (a[0] == a[4] && a[1] == a[3])
//     {
//         Console.WriteLine($"Число {a} является палиндромом ");
//     }
//     else
//     {
//         Console.WriteLine($"Число {a} не является палиндромом ");
//     }
// }
// else
// {
//     Console.WriteLine($"Не соблюдено условие {(b == 5)}. Число не является пятизначным");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты первой точки");
// Console.Write("X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки");
// Console.Write("X: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double Range(int x11, int y11, int z11, int x21, int y21, int z21)
// {
//     int rangeX = x11 - x21;
//     int rangeY = y11 - y21;
//     int rangeZ = z11 - z21;
//     double rangeB = Math.Sqrt(rangeX * rangeX + rangeY * rangeY + rangeZ * rangeZ);
//     return rangeB;
// }
// double result = Range(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"A: ({x1}, {y1}, {z1}); B: ({x2}, {y2}, {z2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= a; i++)
// {
//     Console.WriteLine($"Диапазон кубов чисел: {i * i * i}");
// }