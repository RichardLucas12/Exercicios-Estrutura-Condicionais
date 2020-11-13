using System;

namespace _2_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu ano de nascimento");
            int  nascimento = int.Parse(Console.ReadLine());

            int  ano = 2020 ;

            int idade = ano - nascimento;

            double seman = idade*52.1786;

            Console.WriteLine("Voce tem : "+ idade + " anos");
            Console.WriteLine("voce tem : "+ seman + " semanas de existencia");

        }
    }
}
