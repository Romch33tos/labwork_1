using System;

class Program
{
   static void firstProgram() 
   {
      Console.Write("Введите число: ");
      int number = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите показатель степени: ");
      int degree = Convert.ToInt32(Console.ReadLine());

      double result = Math.Round(Math.Exp(degree * Math.Log(number)));

      Console.WriteLine($"{number}^{degree} = {result}\n");
    }

    static void secondProgram() 
    {
      Console.Write("Введите число x: ");
      string x_number = Console.ReadLine();

      char secondDigit = x_number[1];
      string newNumber = x_number.Remove(1, 1) + secondDigit;

      Console.WriteLine($"Число n: {newNumber}\n");
    }

    static void Main()
    {
      string choice;

      while (true) 
      {       
        Console.WriteLine("Введите номер команды:\n1. Запуск программы №1\n2. Запуск программы №2\n3. Выход");
        choice = Console.ReadLine();

          switch(choice) {
            case "1":
              firstProgram();
              break;
            case "2":
              secondProgram();
              break;
            case "3":
              Environment.Exit(0);
              break;
            default:
              Console.WriteLine("Некорректная команда!");
              break;
          }     
      }
    }
}