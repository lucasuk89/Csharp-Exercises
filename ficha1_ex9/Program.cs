using System;

namespace ficha1_ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Insira um numero");
            num = Int32.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("O numero " + num + " é par");
            }
            else
            {
                Console.WriteLine("O numero " + num + " é impar");
            }
        }
    }
}
