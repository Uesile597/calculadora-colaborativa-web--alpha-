using System;

namespace CalculadoraWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Colaborativa Web");
            
            
            Console.WriteLine("Escolha uma das opções abaioxo: ");
            Console.WriteLine("1 - Adição.");
            Console.WriteLine("2 - Subtração.");
            Console.WriteLine("3 - Multiplicação.");
            Console.WriteLine("4 - Divisão.");
            Console.WriteLine("5 - Potenciação.");
            int opcao = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escreva o primeiro número:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número:");
            double b = double.Parse(Console.ReadLine());

            double resultado = 0;

        if (opcao == 1)
             {
                resultado = Adicao(a, b);
             }
        else if(opcao == 2)
              {
                resultado = Subtracao(a, b);
              }
        else if(opcao == 3)
              {
                resultado = Multiplicacao(a, b);
              }
            
        else if(opcao == 4)
              {
                
                resultado = Divisao(a, b);
              }
            
        else if(opcao == 5)
              {

                resultado = Potenciacao(a, b);
              }
            Console.WriteLine($"Resultado: {resultado}");
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


 
        public static double Potenciacao(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
