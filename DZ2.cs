// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// int InCenter(int a)
// {
//    int result = ((a / 10) % 10);
//    return result;
// }

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = InCenter(num);
// Console.WriteLine(result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// int MakeArray (int a)
// {
//    int result = -1;
//    if (a < 100)
//    {
//       Console.Write("Третьей цифры нет, держи: " );
//    }
//    else
//    {
//      while (a > 999) 
//    {
//       a = a / 10;
//    }
//    result = a % 10;
//    }
//    return result;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = MakeArray(num);
// Console.WriteLine(result);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

 
 
//  int day (int a) 
// {
//    int result = a;
//       if (a == 7 || a == 6)
//    {
//       Console.Write("Выходной день под цифрой " );
//    }
//    else
//    {
//       Console.Write("Рабочий день под цифрой ");
//    }
//    return result;
// }


// Console.WriteLine("Введите число от 1 до 7: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = day(num);
// Console.WriteLine(result);

