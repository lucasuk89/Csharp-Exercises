using System;

namespace ficha1_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,soma;
            Console.WriteLine("Insira um numero");
            // Vai ser lido com o readline uma string e vai ser convertida para um numero inteiro.
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero");
            n2 = Int32.Parse(Console.ReadLine());

            //Colocar o Parenteses entre os n1 e n2 para que seja feito o calculo e depois concatenado a String.
            //Console.WriteLine("O resultado da soma é " + (n1 + n2));

            //Outra maneira de se fazer a soma.
            soma = n1 + n2;
            Console.WriteLine("O resultado da soma é " + soma);
           

        }
    }
}
