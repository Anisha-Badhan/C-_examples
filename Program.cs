using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            hello
            Console.WriteLine(Check4CHash());
        }

        public static int MyMethod()
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
            }
            return result;
        }

        public static bool IfThirty()
        {
            Console.WriteLine("Enter 1st Integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Integer: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (a == 30 || b == 30 || (a + b) == 30){
                return false;
            }else{
                return false;
            }
        }

        public static String MyString()
        {
            Console.WriteLine("Enter a String: ");
            String str = Console.ReadLine();
            return str.StartsWith("IF") || str.StartsWith("if") || str.StartsWith("If") ? str : String.Concat("If", str);
        }

        public static String RmoveChr(){
            Console.WriteLine("Enter a String: ");
            String str = Console.ReadLine();
            Console.WriteLine("Enter index (range form 0 to " + (str.Length - 1) + "): ");
            int index = Convert.ToInt32(Console.ReadLine());
            return index < str.Length - 1? str = str.Remove(index, 1):("Please enter index within range(0 to " + (str.Length - 1) + ")");
        }

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
            return StrLen < 3 ? str + str + str : str.Substring(0, 3) + str + str.Substring(0, 3); 
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
        

