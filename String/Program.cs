using System;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a String :");
        string user_input = Console.ReadLine();
        Console.Write("Enter a sub-string :");
        string subString = Console.ReadLine();
        string[] array1 =user_input.Split(subString);
        Console.WriteLine(array1);
        int count=0;
        foreach (string i in array1)
        {
            count +=1;
        }
        Console.WriteLine(count-1);
    }
}

