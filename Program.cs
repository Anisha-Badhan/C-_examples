using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Console.WriteLine(MyString());           
         }

        static int MyMethod()
        {
            Console.WriteLine("Enter 1st Integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Integer: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (a == b){
                result = 3 * (a + b);
            }else{
                result = a + b;
            }return result;
        }

        static bool IfThirty(){
            Console.WriteLine("Enter 1st Integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Integer: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if(a==30 || b==30 || (a + b) == 30){
                return false;
            }else{
                return false;
            }
        }

        static String MyString(){
            Console.WriteLine("Enter a String: ");
            String str = Console.ReadLine();
            if (str[0] == 'I' || str[0] == 'i' || str[1] == 'f' || str[1] == 'F'){
                return str;
            }
            else
            {
                return String.Concat("If", str);
            }
        }
    }
}
