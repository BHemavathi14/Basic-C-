using System;
namespace DoWhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        string user_choice;
        bool flag=true;
       
        do
        {
            Console.Write("Enter a number to find odd/even :");
            int user_number = int.Parse(Console.ReadLine());
            if(user_number%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            bool flag1=true;
            while(flag1)
            {
            Console.WriteLine("Do you want continue yes/no :");
            user_choice=Console.ReadLine();
            if(user_choice == "yes"){
                flag=true;
                flag1=false;
            }
            else if(user_choice == "no")
            {
                flag = false;
                flag1=false;
            }
            else
            {
                Console.WriteLine("Please provide valid input");
                //flag1 = true;
            }
            }


        }while(flag);
    }
}