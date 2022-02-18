using System;

namespace ficha1_ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            // DESCOBRINDO A AREA DE UM TRIANGULO
            double _base, _altura;

            Console.WriteLine("Insira o valor da base do triangulo");
            _base = Double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da altura do triangulo");
            _altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("A área do Triangulo é " + (_base * _altura / 2));

        }
    }
}
