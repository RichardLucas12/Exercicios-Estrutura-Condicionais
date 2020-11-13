using System;

namespace _1_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua idade em anos");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade *12 ;
            int dias = idade * 365;
            int horas = idade * 8760;
            int minutos = idade * 525600;
            
            Console.WriteLine("sua idade em anos é : " + idade);
            Console.WriteLine("idade em meses : "+ meses);
            Console.WriteLine("idade em dias : " + dias);
            Console.WriteLine("idade em horas : " + horas);
            Console.WriteLine("idade em minutos : " + minutos);
        }
    }
}
