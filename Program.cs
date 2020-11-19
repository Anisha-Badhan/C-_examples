using System;

namespace ConsoleApp1
{
    class Program
    {
        // Please don't use console.writeline inside the methods, call the methods from Main() and pass parameters.


        static void Main(string[] args)
        {
            Console.WriteLine(print_subStr("HelloWorld", "1 4"));
            String[] arr = { "Julia", "Samantha", "Samantha_21", "1samantha", "Samatha?10_2A" };
            name_validity(5, arr);
            
            
            String[] param = { "lmnop", "bcxz" };

            string[] result = funnyString(param);

            for(int i =0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);

            }
        }

        /*
        * @param int a
        * @param int b
        * @return int
       */
        public static int MyMethod(int a, int b)
        {

            // This is good, but can you try to use Ternary Opertor here to make it compact.

            return (a == b ? 3 * (a + b) : a + b);
        }

        public static bool IfThirty(int a, int b)
        {
            // This is good, but can you try to use Ternary Opertor here to make it compact.
            return (a == 30 || b == 30 || (a + b) == 30);
        }

        /*
        * @param String str
        * @return String
       */
        public static String MyString(String str)
        {
            // Wrap the condition in () --> (str.StartsWith("IF") || str.StartsWith("if") || str.StartsWith("If"))
            return (str.StartsWith("IF") || str.StartsWith("if") || str.StartsWith("If") ? str : String.Concat("If", str));
        }

        /*
        * @param String str
        * @param int index
        * @return String
       */
        public static String RmoveChr(String str, int index)
        {
            // Wrap the condition in ()
            return (index < str.Length - 1 ? str = str.Remove(index, 1) : ("Please enter index within range(0 to " + (str.Length - 1) + ")"));
        }

        // Look for a Method called Substring() and try to do this question with that.
        /*
        * @param String str
        * @return String
       */
        public static String Exchange(String str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }

        /*
        * @param String str
        * @return String
       */
        public static String Repeat4times(String str)
        {
            return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }

        /*
        * @param String str
        * @return String
       */
        public static String Addchar(String str)
        {
            String s = str.Substring(str.Length - 1);
            return s + str + s;
        }

        /*
        * @param str
        * @return String
       */
        public static String AddStr(String str)
        {
            int StrLen = str.Length;

            // Wrap the condition in ()
            return (StrLen < 3 ? str + str + str : str.Substring(0, 3) + str + str.Substring(0, 3));
        }

        /*
        * @param String str
        * @return boolean
       */
        public static bool Check4CHash(String str)
        {
            return (str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
        }

        /*
        * @param int x
        * @param int y
        * @param int z
        * @return boolean
       */
        public static bool TestRange(int x, int y, int z)
        {
            return (x >= 20 && x <= 50) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50);
        }

        /*
        * @param array arr
        * @param int d
        * @return void
       */
        public static void ArrRotation(int[] arr, int d)
        {
            int[] arr1 = new int[arr.Length];
            for (int i = d; i < arr.Length; i++)
            {
                arr1[i - d] = arr[i];
            }
            for (int i = 0; i < d; i++)
            {
                arr1.SetValue(arr[i], arr.Length - d + i);
            }
            foreach (int i in arr1)
            {
                System.Console.Write("{0} ", i);
            }
        }

        /*
         * @param String
         * @param String
         * @return String
         */
        public static String print_subStr(String str, String index)
        {
            String[] indices = (index.Split(" "));
            int start = Convert.ToInt32(indices[0]);
            int end = Convert.ToInt32(indices[1]);
            int n = str.Length;
            foreach (Char c in str)
            {
                if (!Char.IsLetter(c))
                {
                    Console.WriteLine("please enter a valid string");
                }
            }
            if (start < 0 || start >= end || end > n)
            {
                Console.WriteLine("Enter valid indices");
            }
            int length = end - start + 1;
            return str.Substring(start, length);
        }
        
        
       /*
         * @param int n
         * @paran Array
         * @return void
        */
        public static void name_validity(int n, String[] arr)
        {
            String x = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < 8 || arr[i].Length > 30)
                {
                    Console.WriteLine(arr[i] + " Invalid Name");
                }
                else
                {
                    x = arr[i];
                    int m = 0;
                    if (!Char.IsLetter(x[0]))
                    {
                        Console.WriteLine(x + " Invalid Name");
                    }
                    else
                    {
                        for (int j = 1; j < x.Length; j++)
                        {
                            if ((int)x[j] < 47 || ((int)x[j] >= 58 && (int)x[j] <= 64) || ((int)x[j] >= 91 && (int)x[j] <= 94) || (int)x[j] == 93)
                            {
                                m = m + 1;
                            }
                        }
                        Console.WriteLine(m != 0 ? x + " Invalid Name" : x + " Valid name");
                    }
                }
            }
            
        }
        
        /*
         * @param int q
         * @param string s
         * @return String[]
        */
       public static String[] funnyString(int q,String[] s)
        {
            String[] results=new string[q];

            for(int k = 0; k < s.Length; k++)
            {
                char[] arr = s[k].ToCharArray();
                Array.Reverse(arr);
                String r = new string(arr);
                int temp = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    int x = Math.Abs((int)s[k][i] - (int)s[k][i - 1]);
                    int y = Math.Abs((int)r[i] - (int)r[i - 1]);
                    if (x != y)
                    {
                        temp = temp + 1;
                    }
                }
                results[k] = (temp != 0 ? "Not funny" : "Funny string");
            }

            return results;
            
        }
    }
}
        

