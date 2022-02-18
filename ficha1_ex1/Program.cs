using System;

namespace ficha1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double precokg;
            int num_kg;
            double final;

            Console.WriteLine("Qual o preço do kg?");
            precokg = Double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas gramas comprou");
            num_kg = Int32.Parse(Console.ReadLine());

            Console.WriteLine("O valor final a ser pago é " + (precokg * num_kg));

             

           //Outra maneira de se fazer criando uma terceira variavel ex: final)
            //final = precokg * num_kg;
            //Console.Write("O valor final é " + final);


        }
    }
}

