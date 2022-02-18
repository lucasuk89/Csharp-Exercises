using System;

namespace ficha1_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, dif;
            Console.WriteLine("Insira um numero");
            // Vai ser lido com o readline uma string e vai ser convertida para um numero inteiro.
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero");
            n2 = Int32.Parse(Console.ReadLine());

            //Colocar o Parenteses entre os n1 e n2 para que seja feito o calculo e depois concatenado a String.
            Console.WriteLine("A diferença entre os numeros é  " + (n1 - n2));

            //Outra maneira de se fazer a diferença
            dif = n1 - n2;
            Console.WriteLine("A diferença entre os numeros é " + dif);
        }
    }
}
