using System.ComponentModel.Design;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (Int16 i = 1; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("hello Goodbye");
                    Console.ReadLine();
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Hello");
                    Console.ReadLine();
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }    
            }
        }
    }
}
