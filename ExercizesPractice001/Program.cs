// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// void GetDiapazone(int quadrant)
// {
//     if(quadrant == 1) System.Console.WriteLine(" x > 0, y > 0");
//     else if(quadrant == 2) System.Console.WriteLine("x < 0, y > 0");
//     else if(quadrant == 3) System.Console.WriteLine("x < 0, y < 0");
//     else if(quadrant == 4) System.Console.WriteLine("x > 0, y < 0");
//     else System.Console.WriteLine("Wrong numbers");
// }

// System.Console.Write("input number of quadrant: ");
// int quadNum = Convert.ToInt32(Console.ReadLine());
// GetDiapazone(quadNum);


// Напишите программу, которая выводит случайное трёхзначное число
//  и удаляет вторую цифру этого числа.

// int CutNumber(int number)

// {
//     int sot = number / 100;
//     int ed = number % 10;
//     int result = sot * 10 + ed;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// Console.WriteLine("Current three digit number is " + randNumber);
// int newNumber = CutNumber(randNumber);
// Console.WriteLine("New number is: " + newNumber);


// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// int NumBers(int number)
// {
//     int sot = number / 10;
//     int ed = number % 10;
//     int max = 0;
//     if (sot > ed)

//     {
//         max = sot;
//     }
//     else
//     {
//         max = ed;
//     }
// return max;
// }

// int randNumber = new Random().Next(10, 100);
// Console.WriteLine("Current two digit number is " + randNumber);
// int newNumber = NumBers(randNumber);
// System.Console.WriteLine("The bigger number is:" + newNumber);

// Напишите программу, которая будет принимать на вход два числа 
// и определять, является ли второе число кратным первому.

// bool NumbersTwo(int a, int b)
// {
//     if (b % a == 0 || a % b == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// System.Console.WriteLine("Введите первое число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int d = Convert.ToInt32(Console.ReadLine());

// bool tf = NumbersTwo(c, d);
// System.Console.WriteLine(tf);




// Напишите программу, которая будет принимать на вход два числа 
// и определять, является ли одно число квадратом другого.

// bool QuadNum(int num1, int num2)
// {
//     if (num1 == num2 * num2 || num2 == num1 * num1)
//     {
//         return true;
//     }
//     else return false;
// }

// System.Console.WriteLine("Введите первое число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int d = Convert.ToInt32(Console.ReadLine());

// bool tf = QuadNum(c, d);
// System.Console.WriteLine(tf);



// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


// int CutNumber(int numbers)
// {
//     int num1 = numbers / 10;
//     int num2 = numbers % 10;
//     int result = num1 / num2;
// }


// System.Console.Write("Введи число ");
// int c = Convert.ToInt32(Console.ReadLine());
//  int sot = c / 100; // (Убирает последние числа)
//  int ed = c % 10;  // (Убирает первые числа)
//  Console.WriteLine($"Получилось {sot}, {ed} ");



// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

// void GetDiapazone(int x, int y)
// {
//     if( x > 0 && y > 0) System.Console.WriteLine("quadrant 1");
//     else if(x < 0 && y > 0) System.Console.WriteLine("quadrant 2");
//     else if(x < 0 && y < 0) System.Console.WriteLine("quadrant 3");
//     else if(x > 0 && y < 0) System.Console.WriteLine("quadrant 4");
//     else if(x == 0 || y == 0) System.Console.WriteLine("wrong coordinates");
// }

// System.Console.Write("input coordinates for x: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input coordinates for y: ");
// int b = Convert.ToInt32(Console.ReadLine());

// GetDiapazone(a, b);


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт квадраты чисел от 1 до N.



// void Quad(int n)
// {
//     int count = 1;
//     Console.WriteLine("Quadrants of numbers: ");
//     while(count < n + 1)
//     {
//         Console.Write(count * count + " ");
//         count = count + 1;
//     }
// }
// System.Console.WriteLine("Enter number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Quad(n);

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.


// double Distance(double x1, double y1, double x2, double y2)
// {
//     double res1 = Math.Pow(x2 - x1, 2);
//     double res2 = Math.Pow(y2 - y1, 2);
//     double result = Math.Sqrt(res1 + res2);
//     return result;
// }

// System.Console.WriteLine("Enter the coordinates of the first point");
// double x1 = Convert.ToInt32(Console.ReadLine());
// double y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter the coordinates of the second point");
// double x2 = Convert.ToInt32(Console.ReadLine());
// double y2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Distance between points is: " + Distance(x1, y1, x2, y2));

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         System.Console.Write($"input an {i+1} element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;

// }

// void ShowArray(int[] array)
// {

// }

// Console.Write("Input a length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(length);
// ShowArray(newArray);




// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

// int GetSum(int num)
// {
//     int sum = 0;
//     for(int current = 1; current <= num; current++)
//     {
//         sum += current; //sum = sum + current;
//     }
//     return sum;
// }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = GetSum(a);
// System.Console.WriteLine($"Your number is {result}");


// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.

// int Numbers(int n)
// {
//     int count = 0;
//     while(n != 0)
//     {
//         n = n / 10;
//         count += 1;
//     }
//     return count;

// }
// System.Console.WriteLine("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = Numbers(num);
// System.Console.WriteLine($"Your amount is: {result}");


// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.


// int GetSum(int num)
// {
//     int sum = 0;
//     for(int current = 1; current <= num; current++)
//     {
//         sum = (current - 1) * current; //sum = sum + current;
//     }
//     return sum;
// }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = GetSum(a);
// System.Console.WriteLine($"Your number is {result}");



// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//       System.Console.Write($"input an {i + 1} element: ");
//       array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// int GetSumOfNegative(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         System.Console.Write(array[i] + " | ");
//     System.Console.WriteLine();
// }



// System.Console.Write("input a length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input a min value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input a max value: ");

// int[] newArray = CreateRandomArray(length, min, max);
// ShowArray(newArray);





