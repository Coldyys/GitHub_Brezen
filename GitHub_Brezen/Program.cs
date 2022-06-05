using System;

namespace GitHub_Brezen
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            int con1 = Int32.Parse(n1);
            int con2 = Int32.Parse(n2);

            int min = Math.Min(con1,con2);
            int max = Math.Max(con1,con2);
            
            Console.WriteLine($"{min},{max}");




        }
    }
}
