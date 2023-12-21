using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите математическое выражение:");
        string expression = Console.ReadLine();

        List<int> numbers = new List<int>();
        List<char> operations = new List<char>();

        string currentNumber = "";
        foreach (char c in expression)
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

        int result = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            switch (operations[i - 1])
            {
                case '+':
                    result += numbers[i];
                    break;
                case '-':
                    result -= numbers[i];
                    break;
                case '*':
                    result *= numbers[i];
                    break;
                case '/':
                    result /= numbers[i];
                    break;
            }
        }
        Console.WriteLine("\nРезультат: " + result);
        Console.ReadLine();
    }
}
