using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        // getting user input
        Console.Write("Enter your name : ");
        string name = Console.ReadLine();

        Console.Write("Enter your age : ");
        int age = int.Parse(Console.ReadLine());

        Console.Write ("Enter mark of Subject1: ");
        int mark1 = int.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject2: ");
        int mark2 = int.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject3: ");
        int mark3 = int.Parse(Console.ReadLine());

        float total = mark1 +mark2 +mark3;
        float average = total /3;

        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());

        Console.Write("Enter a mobile number: ");
        long mobileNumber = long.Parse(Console.ReadLine());
        
        Console.Write("Enter mail id: ");
        string mail = Console.ReadLine();


        // displaying trainee details

        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine($"Name:{name}\nAge:{age}\nMobile:{mobileNumber}\nMarks1:{mark1}\nMarks2:{mark2}\nMarks3:{mark3}\nTotal:{total}\nAverage:{average}\nGrade:{grade}\nMail id : {mail}");

    }
}
