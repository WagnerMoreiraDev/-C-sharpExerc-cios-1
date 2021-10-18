using System;

namespace Exercício01
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            string dado;
            
            Console.Write("Introduza a Nota 1: ");
            dado = Console.ReadLine();
            nota1 = Convert.ToDouble(dado);

            Console.Write("Introduza a Nota 2: ");
            dado = Console.ReadLine();
            nota2 = Convert.ToDouble(dado);

            media = (nota1 + nota2) / 2;

            if (media == 10) {
                Console.WriteLine("Aprovado com Distinção");
            } else if (media >= 7) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
            }
           
        }
    }
}
