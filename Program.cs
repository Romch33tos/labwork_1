using System;

class Program
{
   static void FirstProgram() 
   {
      Console.Write("Введите число: ");
      int number = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите показатель степени: ");
      int degree = Convert.ToInt32(Console.ReadLine());
      
      int result = 1;
      
      for (int counter = 0; counter < degree; ++counter)
        {
            result *= number;
        }
      
      Console.WriteLine($"{number}^{degree} = {result}\n");
    }

    static void SecondProgram() 
    {
      Console.Write("Введите число x: ");
      string numberX = Console.ReadLine();

      char secondDigit = numberX[1];
      string newNumber = numberX.Remove(1, 1) + secondDigit;

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
              FirstProgram();
              break;
            case "2":
              SecondProgram();
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
