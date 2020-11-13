using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade");
            int idade = int.Parse(Console.ReadLine());

            if ( idade >= 5 && idade <= 7)
            {
                Console.WriteLine("categoria : infantil A");
            }
            else
            {
                 if ( idade >= 8 && idade <= 10)
                 {
                      Console.WriteLine("categoria : infantil B");
                 }
                 else
                 {
                     if ( idade >= 11 && idade <= 13)
                     {
                        Console.WriteLine("categoria : Juvenil A"); 
                     }
                     else
                     {
                         if( idade >= 14 && idade <= 17)
                         {
                            Console.WriteLine("categoria : Juvenil B"); 
                         }
                         else
                         {
                             Console.WriteLine("categoria : Senior"); 
                         }
                     }
                 }

            }
        }
    }
}
