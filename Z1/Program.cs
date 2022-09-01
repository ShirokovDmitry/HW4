// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число 1");
double a =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 2");
double b =Convert.ToDouble(Console.ReadLine());

double sum = 0;
sum = Math.Pow(a, b);
Console.WriteLine("Сумма = " + sum);



