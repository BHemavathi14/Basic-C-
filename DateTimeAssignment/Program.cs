using System;
namespace DateTimeAssignment;
class Program
{
    public static void Main(string[] args)
    {
        
        DateTime date= new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date);

        // getting user input

        DateTime date1;
        Console.Write("Enter the date in this yyyy/MM/dd hh:mm:ss tt format : ");
        bool temp = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date1);

        while(!temp)
        {
            Console.WriteLine("Invalid format");
            Console.Write("Enter the date in this yyyy/MM/dd hh:mm:ss tt format : ");
            temp = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date1);
        }

        string newDate = date1.ToString("yyyy/MM/dd hh:mm:ss tt");
        string[] name = newDate.Split(' ','/',':');
        for (int i =6 ; i>0 ; i--)
        {
            Console.Write($"{name[i]} ");
        }

         Console.WriteLine(date1.ToString("yyyy/MM/dd"));
         //Console.WriteLine(date1.DayOfWeek);
         //Console.WriteLine(date1.DayOfYear);
    }
}