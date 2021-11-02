using System;

namespace Kruh2
{
    class Program
    {
        static void Main(string[] args)
        {
            double prumer;
            double polomer;
            double vyber;
            double obvod;
            double obsah;


            Console.WriteLine("Kruh");
            Console.WriteLine();

            Console.WriteLine("Vyber možností (1 prumer)" +
                           "                 (2 polomer)");


            double.TryParse(Console.ReadLine(), out vyber);


           
            
            
            if (vyber == 1) 
            {
                Console.WriteLine("Zadej prumer");
                Double.TryParse(Console.ReadLine(), out prumer);


                obvod = 3.14 * prumer;
                Console.WriteLine($"Obvod je {obvod}");

                obsah = 3.14 * (prumer * prumer) / 4;
                Console.WriteLine($"Obsah je {obsah}");
            
            
            }
            else if (vyber == 2)
            {
                Console.WriteLine("Zadej poloměr");
                Double.TryParse(Console.ReadLine(), out polomer);

                obvod = 2 * 3.14 * polomer;
                Console.WriteLine($"Obvod kruhu je {obvod}");

                obsah = 3.14 * (polomer * polomer);
                Console.WriteLine($"Obsah kruhu je {obsah}");
            
            
            }
            










        }
    }
}
