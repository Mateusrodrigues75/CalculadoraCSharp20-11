using System;

namespace CalculadoraCSharp20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma operação: ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro Número: ");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Segundo Número: ");
            float num2 = float.Parse(Console.ReadLine());
            
            float resultado = 0;

            

            switch (operacao)
            {
                case "Soma":
                Somar(num1, num2);
                break;
                
                case "Subitrair":
                Subtrair(num1, num2);
                break;

                default:
                    break;
            }
            Console.WriteLine(resultado);
            

        }
        static void Somar(float a, float b){
            Console.WriteLine("Resultado da Soma: ");
            Console.WriteLine(a+b);
        }

        static void Subtrair(float a, float b){
            Console.WriteLine("Resultado da Subtração:");
            Console.WriteLine(a-b);
        }
    }
}
