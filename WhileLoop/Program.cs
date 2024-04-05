using System;

namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
       int number1=0;
       while(number1<25)
       {
        if(number1%2==0)
        {
            Console.WriteLine(number1);
        }
        number1++;
       }


       // 2nd exercise
       while(true)
       {
        Console.Write("Enter the Number:");
       int user_number ;
       bool user_input =int.TryParse(Console.ReadLine(),out user_number);
        if(user_input)
        {
            Console.WriteLine(user_number);
            break;

        }
        else
        {
            Console.WriteLine("Invalid input format. Please enter the input in number format");

        }
        // another way 
        //Console.Write("enter a number ");
        //bool isvalid 
      
       }
  

    }
}
