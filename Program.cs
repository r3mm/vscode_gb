// // Задача 41: Пользователь вводит с клавиатуры M чисел. 
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество чисел: ");
// int M = Convert.ToInt32(Console.ReadLine());

// int[] mas = new int[M];
// int score = 0;

// void FillArray(int M)
// {
//     for (int i = 0; i < M; i++)
//     {
//         System.Console.Write($"Введите число для {(i+1)} элемента: ");
//         mas[i] = Convert.ToInt32(System.Console.ReadLine());
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < M; i++)
//     {
//         System.Console.Write("|" + mas[i] + "|");
//     }
// }

// int DetectArray(int numb)
// {
//     numb = 0;

//     for (int i = 0; i < mas.Length; i++)
//     {
//         if (mas[i] > 0) numb++;
//     }
//     return numb;
// }

// System.Console.WriteLine();
// FillArray(M);

// System.Console.WriteLine();
// PrintArray();

// System.Console.WriteLine();
// System.Console.WriteLine();
// System.Console.WriteLine("Количество чисел больше 0 (нуля) равно: " + DetectArray(score));
// System.Console.WriteLine();

// _________________________________________

// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// System.Console.Write("Введите значение b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите значение k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите значение b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите значение k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double xCord(double b1, double k1, double b2, double k2)
// {
//     double x = 0;
//     x = (b2 - b1) / (k1 - k2);
//     return x;
// }

// double y1 = k1 * xCord(b1, k1, b2, k2) + b1;
// double y2 = k2 * xCord(b1, k1, b2, k2) + b2;

// System.Console.WriteLine($"({y1}; {y2})");