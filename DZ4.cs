// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }

// int numberA = ReadInt("Введите число A: ");
// int numberB = ReadInt("Введите число B: ");
// ToDegree(numberA, numberB);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Введите любое число: ");
// int enterNumber = Convert.ToInt32(Console.ReadLine());
// int result = 0;

// while (enterNumber > 0)
// {
//    result += enterNumber % 10;
//    enterNumber /= 10;
// }

//  Console.WriteLine($"Сумма цифр в числе = {result}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите максимум для элемента массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] lenArray = new int[8];
// int[] randomArray = new int[8];

// for (int i = 0; i < 8; i++)
// {
//    randomArray[i] = new Random().Next(1,n+1);
//    Console.Write(randomArray[i] + "; ");
// }
//  Console.WriteLine();


