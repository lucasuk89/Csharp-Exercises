using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace chamarFraseMaisNome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.WriteLine("Insira o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome);

        }
    }
}
