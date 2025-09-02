using System;
using System.Collections.Generic;
using System.Data;

namespace CalculadoraWeb
{
    class Program
    {
        static List<string> historico = new List<string>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Colaborativa Web");
            
            
            Console.WriteLine("Escolha uma das opções abaioxo: ");
            Console.WriteLine("1 - Adição.");
            Console.WriteLine("2 - Subtração.");
            Console.WriteLine("3 - Multiplicação.");
            Console.WriteLine("4 - Divisão.");
            Console.WriteLine("5 - Radiciação.");
            Console.WriteLine("6 - Limpar");
            Console.WriteLine("7 - Expressão");
            Console.WriteLine("8 - Histórico");
            
            int opcao = int.Parse(Console.ReadLine());

            if(opcao >= 1 && <= 4)
    {
            
            Console.WriteLine("Escreva o primeiro número:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número:");
            double b = double.Parse(Console.ReadLine());
            

        if (opcao == 1)
             {
                resultado = Adicao(a, b);
                historico.Add($" {a} + {b} = {resultado}");
             }
        else if(opcao == 2)
              {
                resultado = Subtracao(a, b);
                historico.Add($" {a} - {b} = {resultado}");
              }
        else if(opcao == 3)
              {
                resultado = Multiplicacao(a, b);
                historico.Add($" {a} * {b} = {resultado}");
              }
            
        else if(opcao == 4)
              {
                
                resultado = Divisao(a, b);
                historico.Add($" {a} / {b} = {resultado}");
              }
     }       
        else if(opcao == 5)
              {
            Console.WriteLine("Escreva o número:");
            double a = double.Parse(Console.ReadLine());
            resultado = Radiciacao(a);

            historico.Add($" Raiz de {a} = {resultado}");
              }
            Console.WriteLine($"Resultado: {resultado}");
       

            
         else if(opcao == 6)
         {
             Console.Clear();
         }

        else if(opcao == 7)
        {
            Console.WriteLine("Digite a escpressão:");
            string expressao = Console.ReadLine();

            var reultado = new DataTable().Compute(expressao, null);
            Console.WriteLine("Resultado: " + resultado);
        }
        else if(opcao == 8)
        {
            Console.WriteLine("Histórico de calculos");

            if(historico.Count == 0);
            {
            Console.WriteLine("Sem Histórico");
            }
            else
    {
        foreach (var item in historico)
        {
            Console.WriteLine(item);
        }
    }
}

            
        
           
                
        }

        public static double Adicao(double a, double b)
        {
            return a + b;
        }

        
        public static double Subtracao(double a, double b)
        {
            return a - b;
        }

        
       public static double Multiplicacao(double a, double b)
        {
           return a * b;
        }

        
        public static double Divisao(double a, double b)
        {
            return a / b;
        }


 
        public static double Radiciacao(double a)
        {
           return Math.Sqrt(a);
        }
        
    }
}
