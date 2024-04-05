using System;
namespace switchCase;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1 :");
        float number1= float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        float number2 = float.Parse(Console.ReadLine());

        Console.Write("Which operation you needed to be perfomed press(+,-,*,/,%): ");
        char operators = char.Parse(Console.ReadLine());
        switch(operators)
        {
            case '+' :
            {
                Console.WriteLine($"{number1 + number2}");
                break;
            }
            case '-' :
            {
                Console.WriteLine($"{number1-number2}");
                break;
            }
            case '*':
            {
                Console.WriteLine($"{number1*number2}");
                break;
            }
            case '/':
            {
                Console.WriteLine($"{number1/number2}");
                break;
            }
            case '%':
            {
                Console.WriteLine($"{number1%number2}");
                break;
            }
            default:
            {
                Console.WriteLine("Invlid operation");
                break;
            }

        }
    }
}