using System;

class Program {
  public static void Main (string[] args) {
    while (true)
    {
      Console.WriteLine("Select activity from 1-5.");
      Console.Write("Activity: ");
      string input = Console.ReadLine();

      if (int.TryParse(input, out int activityNumber))
      {
        switch (activityNumber)
        {
          case 1:
            Activity1();
            break;
          case 2:
            Activity2();
            break;
          case 3:
            Activity3();
            break;
          case 4:
            Activity4();
            break;
          case 5:
            Activity5();
            break;
          default:
            Console.WriteLine("Activity does not exist.");
            break;
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a valid activity number (1-5).");
      }
    }
  }

  static void Activity1()
  {
    Console.WriteLine("Enter the amount:");
    string input = Console.ReadLine();

    if (decimal.TryParse(input, out decimal amount))
    {
      string person = aP(amount);
      if (person != null)
      {
        Console.WriteLine($"{person} is found in Php {amount}.");
      }
      else
      {
        Console.WriteLine($"Invalid Denomination: {amount}.");
      }
    }
    else
    {
      Console.WriteLine($"Invalid input. Please enter a valid decimal value.");
    }
  }

  static string aP(decimal amount)
  {
    switch (amount)
    {
      case 0.01m:
      case 0.05m:
      case 0.25m:
        return "No Person";
      case 1:
        return "Jose Rizal";
      case 5:
        return "Emilio Aguinaldo";
      case 10:
        return "Andres Bonifacio & Apolinario Mabini";
      case 20:
        return "Manuel L. Quezon";
      case 50:
        return "Sergio Osmeña";
      case 100:
        return "Manuel Roxas";
      case 200:
        return "Diosdado Macapagal";
      case 500:
        return "Benigno Aquino Sr. & Corazon Aquino";
      case 1000:
        return "Jose Abad Santos, Vicente Lim & Josefa Llanes Escoda";
      default:
        return null;
    }
  }

  static void Activity2()
  {
    for (int i = 1; i <= 30; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine(i + " - FooBar");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine(i + " - Foo");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine(i + " - Bar");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }

  static void Activity3()
  {
    string input;
    string previousInput = "";

    do
    {
      Console.WriteLine("Enter something: ");
      input = Console.ReadLine();

      if (previousInput != "")
        Console.WriteLine(previousInput + " " + input);
      else
        Console.WriteLine(input);

      previousInput += input;
    }
    while (input != "exit");

    Console.WriteLine("Program closed.");
  }

  static void Activity4()
  {
    int num;
    while (true)
    {
      Console.WriteLine("Enter a number: ");
      string input = Console.ReadLine();

      if (int.TryParse(input, out num))
      {
        if (num == 0)
        {
          Console.WriteLine("Program Terminated.");
          break;
        }
        else
        {
          printTriangle(num);
        }
      }
      else
      {
        Console.WriteLine($"Invalid value: {input}.");
      }
    }
  }

  static void printTriangle(int n)
  {
    for (int i = 1; i <= n; i++)
    {
      for (int j = 1; j <= n - i; j++)
      {
        Console.Write(" ");
      }
      for (int k = 1; k <= 2 * i - 1; k++)
      {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }

  static void Activity5()
  {
    int previousNum = 0;
    string message = "";

    while (true)
    {
      Console.Write("Enter something: ");
      string input = Console.ReadLine();

      if (input.ToLower() == "exit")
      {
        Console.WriteLine("Program Terminated.");
        break;
      }

      int num;
      bool isNumeric = int.TryParse(input, out num);

      if (isNumeric)
      {
        int currentNum = int.Parse(input);
        int sum = previousNum + currentNum;
        Console.WriteLine($"Adding {previousNum} to {currentNum} = {sum}.");
        previousNum = currentNum;
      }
      else
      {
        if (!string.IsNullOrWhiteSpace(message))
        {
          Console.WriteLine($"Current Message is: {message}{input}");
        }
        else
        {
          Console.WriteLine($"Current Message is: {input}");
        }
        message += input + " ";
      }
    }

    Console.WriteLine("Current message is: " + message);
  }
}
