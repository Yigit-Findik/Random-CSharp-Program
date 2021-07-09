using System;

namespace FirstConsoleApp
{
    class Program
    {
        public static string title = "C# Essential Training";
        public static int whichPart;

        static void Main(string[] args)
        {  

            whichPart = 2;
            
            String message = $"Welcome {title} Part {whichPart}";
            Console.WriteLine(message);
            Console.WriteLine("Press the enter key to exit.\r\n");
        }
 
    }
}
