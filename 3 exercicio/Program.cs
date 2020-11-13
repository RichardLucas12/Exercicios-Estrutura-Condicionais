using System;

namespace _3_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salario ?");
            double salario = double.Parse(Console.ReadLine());

             double porc = 0.3*salario;
             double ajustado = salario + porc ; 
             
             if(salario< 500)
             {
                 Console.WriteLine("seu salario foi ajustado");
                 Console.WriteLine("seu salario : " + "R$ " + ajustado);
             } 
             
             else
             {
                 Console.WriteLine("salario não elegivel para ajuste");
                 Console.WriteLine("salario : "+"R$ " + salario  );

             }
             
        }
    }
}
