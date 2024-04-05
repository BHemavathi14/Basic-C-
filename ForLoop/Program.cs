using System;
using System.Diagnostics.CodeAnalysis;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int startNumber= int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        int endNumber = int.Parse(Console.ReadLine());
        
        int sum=0;

        for (int i=startNumber+1 ; i<endNumber; i++)
        {
            sum += i*i;

        }
        Console.WriteLine(sum);
    }
}