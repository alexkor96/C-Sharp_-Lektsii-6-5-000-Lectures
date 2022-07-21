// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 1 число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int Max = 0;
if(n1 < n2) Max = n2;
else Max = n1;
if(Max < n3) Max = n3;
Console.WriteLine("Max = " + Max);