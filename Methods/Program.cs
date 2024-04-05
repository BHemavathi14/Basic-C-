using System;
namespace Methods;
class Program
{
    static  bool flag1  ;
    public static void Main(string[] args)
    {
       
        do
        {
            
            bool flag2=true;
            Console.WriteLine("Enter the Number1: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number2");
            double number2 = double.Parse(Console.ReadLine());
            Console.Write("Choose an option to perform Arithmatic Operations\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division(Enter 1/2/3/4)");
            int userChoice = int.Parse(Console.ReadLine());
            switch(userChoice)
            {
                case 1 :
                {
                    Addition(number1,number2);

                    break;
                }
                case 2 :
                {
                    Subtraction(number1,number2);
                    break;
                }
                case 3 :
                {
                    Multiplication(number1,number2);
                    break;
                }
                case 4 :
                {
                    Division(number1,number2);
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Input");
                    flag2 = false;
                    break;
                    
                }
            }
            while(flag2)
            {
            Console.Write("Do you want to continue provide yes/no");
            string userDecision=Console.ReadLine();
            if (userDecision == "yes")
            {
               flag1 = true;
               flag2=false;
            }
            else if (userDecision == "no")
            {
                flag1 = false;
                flag2=false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                flag1=false;
            }
            }
            

        }while(flag1);

        static void Addition(double num1,double num2 )
        {
            Console.WriteLine($"{num1 +num2}");

        }
        
        static void Subtraction(double num1,double num2 )
        {
            Console.WriteLine($"{num1-num2}");

        }
        
        static void Multiplication(double num1,double num2 )
        {
            Console.WriteLine($"{num1*num2}");

        }
        
        static void Division(double num1,double num2 )
        {
            Console.WriteLine($"{num1/num2}");

        }
    }

}

