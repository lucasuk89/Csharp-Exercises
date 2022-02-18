using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ficha1_ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1, l2, l3;

            Console.WriteLine("Insira o lado 1");
            l1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado 2");
            l2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado 3");
            l3 = Int32.Parse(Console.ReadLine());

            if (l1 == 0 || l2 == 0 || l3 == 0 || l1 > l2 + l3 || l2 > l1 + l3 || l3 > l1 + l2)
            {
                Console.WriteLine("Triangulo impossivel");
            }
            else
            {
                if (l1==l2 && l1 ==l3)
                {
                    Console.WriteLine("O triangulo é Equilatero");
                }else if (l1!=l2 && l1!=l3 && l2!=l3)
                {
                    Console.WriteLine("O triangulo é Escaleno");
                }else
                {
                    Console.WriteLine("O triangulo é Isoceles");
                }

            }
            

           }
    }
}
