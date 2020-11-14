using System;

namespace ConsoleApp1
{
    class Program
    {
        // Please don't use console.writeline inside the methods, call the methods from Main() and pass parameters.
        
        static void Main(string[] args){
             MyMethod(4, 5);
        }

        public static int MyMethod(int a int b){
            
            // This is good, but can you try to use Ternary Opertor here to make it compact.
            int result = 0;
            return (a == b ? 3 * (a + b) : a + b);
        }

        public static bool IfThirty(int a int b)
        {
            // This is good, but can you try to use Ternary Opertor here to make it compact.
            return (a == 30 || b == 30 || (a + b) == 30)
        }

        public static String MyString(String str)
        {
            // Wrap the condition in () --> (str.StartsWith("IF") || str.StartsWith("if") || str.StartsWith("If"))
            return (str.StartsWith("IF") || str.StartsWith("if") || str.StartsWith("If") ? str : String.Concat("If", str));
        }

        public static String RmoveChr(String str int index){
            // Wrap the condition in ()
            return (index < str.Length - 1? str = str.Remove(index, 1):("Please enter index within range(0 to " + (str.Length - 1) + ")"));
        }

        // Look for a Method called Substring() and try to do this question with that.
        public static String Exchange() {
            Console.WriteLine("Enter a String: ");
            String str = Console.ReadLine();
            char[] array = str.ToCharArray(); 
            char temp = array[0]; 
            array[0] = array[str.Length-1];
            array[str.Length-1] = temp; 
            return new string(array);
        }

        public static String Repeat4times()
        {
            Console.WriteLine("Please Enter a String: ");
            String str = Console.ReadLine();
            return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }

        public static String Addchar(){
            Console.WriteLine("Enter a String: ");
            String str = Console.ReadLine();
            String s = str.Substring(str.Length - 1);
            return s + str + s;
        }

        public static String AddStr(){
            Console.WriteLine("Enter a string: ");
            String str = Console.ReadLine();
            int StrLen = str.Length;
            
            // Wrap the condition in ()
            return (StrLen < 3 ? str + str + str : str.Substring(0, 3) + str + str.Substring(0, 3)); 
        }

        public static bool Check4CHash(){
            Console.WriteLine("Enter a string: ");
            String str = Console.ReadLine();
            return (str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
        }

        public static bool TestRange(int x, int y, int z){
            return (x >= 20 && x <= 50) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50);
        }
    }
            
} 
        

