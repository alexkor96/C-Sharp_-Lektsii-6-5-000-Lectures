// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 % 2 == 0)
{
   Console.Write( n1 + " Число четное");
} 
else Console.Write(n1 + "Число не четное");