using System;

namespace CalculadoraWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Colaborativa Web");
            // Integrante 1: Implementar menu e chamar as funções
        }

        // Integrante 1
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
            return Mach.Pow(a, b);
        }
    }
}
