// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// void FillArrayRandomNumbers(int[] numbers)
// {
//    for(int i = 0; i < numbers.Length; i++)
//    {
//       numbers[i] = new Random().Next(100,1000);
//    }
// }

// void PrintArray(int[] array)
// {
//    for(int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int count = 0;
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// for (int i = 0; i < numbers.Length; i++)
// {
//    if (numbers[i] % 2 == 0)
//    count++;
// }

// Console.WriteLine($" {count} чётных чисел ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// void FillArrayRandomNumbers(int[] numbers)
// {
//    for(int i = 0; i < numbers.Length; i++)
//    {
//       numbers[i] = new Random().Next(-100,101);
//    }
// }

// void PrintArray(int[] array)
// {
//    for(int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int sumNumbersEvenIndex = 0;
// FillArrayRandomNumbers(numbers);
// // PrintArray(numbers);

// for (int i = 1; i < numbers.Length; i += 2)
// {
//    sumNumbersEvenIndex += numbers[i];
// }
// Console.WriteLine($" Сумма элементов нечетных позичий {sumNumbersEvenIndex} ");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// void FillArrayRandomNumbers(int[] numbers)
// {
//    for(int i = 0; i < numbers.Length; i++)
//    {
//       numbers[i] = new Random().Next(-100,101);
//    }
// }

// void PrintArray(int[] array)
// {
//    for(int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int max = numbers[0];
// int min = numbers[0];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// for (int i = 0; i < numbers.Length; i++)
// {
//    if (numbers[i] > max)
//    {
//       max = numbers[i];
//    }
//    else 
//       if (numbers[i] < min)
//       {
//          min = numbers[i];
//       }
// }

// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

