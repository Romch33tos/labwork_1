using System;
class Program
{
    static void Main()
    {
      Console.Write("Введите число: ");
      int number = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите показатель степени: ");
      int degree = Convert.ToInt32(Console.ReadLine());

      double result = Math.Round(Math.Exp(degree * Math.Log(number)));

      Console.WriteLine($"{number}^{degree} = {result}");
    }
}