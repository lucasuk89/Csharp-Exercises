using System;

namespace ficha1_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Insira um numero");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero");
            n2 = Int32.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                Console.WriteLine("O maior N é : " + n1);
            }
            else
            {
                Console.WriteLine(" O maior N é : " + n2);
            }


        }
    }
}
