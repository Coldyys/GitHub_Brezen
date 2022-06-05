using System;

namespace GitHub_Brezen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadání/načtení čísel
            Console.WriteLine("Zadejte 1. číslo");
            string n1 = Console.ReadLine();
            Console.WriteLine("Zadejte 2. číslo");
            string n2 = Console.ReadLine();
            //Konverze z typu string na int
            int con1 = Int32.Parse(n1);
            int con2 = Int32.Parse(n2);
            //Zjistí nejmenší a největší číslo z dvojice
            int min = Math.Min(con1,con2);
            int max = Math.Max(con1,con2);
            //Vypíše finální output
            Console.WriteLine($"Čísla jsou vypsána od nejmenšího po největší: {min},{max}");




        }
    }
}
