using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите математическое выражение:");
        string input = Console.ReadLine();

        List<int> numbers = new List<int>();
        List<char> operations = new List<char>();

        string currentNumber = "";
        foreach (char c in input)
        {
            if (Char.IsDigit(c))
            {
                currentNumber += c;
            }
            else if (c != ' ')
            {
                numbers.Add(int.Parse(currentNumber));
                currentNumber = "";

                operations.Add(c);
            }
        }
        numbers.Add(int.Parse(currentNumber));

        Console.WriteLine("Список чисел:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nСписок операций:");
        foreach (char operation in operations)
        {
            Console.Write(operation + " ");
        }
    }
}