using System;

namespace ficha1_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco,valorPago,troco;

            Console.WriteLine("Insira o preço do produto");
            preco = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor pago pelo Cliente");
            valorPago = Double.Parse(Console.ReadLine());

            troco = valorPago - preco;
            Console.WriteLine(" O troco é de " + troco + " reais.");

        }
    }
}
