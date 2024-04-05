using System;
using System.Globalization;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array: ");
        int n = int.Parse(Console.ReadLine());
        string[] array =new string[n];
        for (int i=0; i<n; i++)
        {
            Console.Write($"Enter the name{i+1} :");
            string name = Console.ReadLine();
            array[i] =name;
        }
        foreach (string j in array)
        {
            Console.WriteLine(j);
        }
        Console.Write("Enter the name to search:");
        string user_choice = Console.ReadLine();
        int count=0;
        bool flag=true;
        foreach(string k in array)
        {

            if (user_choice==k)
            {
                flag=false;
                Console.WriteLine($"The name is present in array. The index is {count}");    
            }
            count++;   
        }
        if(flag)
            {
                 Console.WriteLine("The name is not present in array");

            }   
    }
}
