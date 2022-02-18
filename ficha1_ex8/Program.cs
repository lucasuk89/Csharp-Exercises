using System;

namespace ficha1_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Insira o primeiro numero");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro numero");
            n3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o quarto numero");
            n4 = Int32.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3 && n1 < n4)
            {
                Console.WriteLine("O menor numero entre eles é " + n1);
            }
            else if (n2 < n1 && n2 < n3 & n2 < n4)
            {
                Console.WriteLine("O menor numero entre eles é " + n2);
            }
            else if (n3<n1 && n3<n2 && n3<n4)
            {
                Console.WriteLine("O menor numero entre eles é " + n3);
            }
            else 
             {
                Console.WriteLine("O menor numero entre eles é " + n4);
             }



        }
    }
}
