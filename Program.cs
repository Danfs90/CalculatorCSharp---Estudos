using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
        
            Console.Clear();     
            Console.WriteLine("O que deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair da calculadora");


            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());     // Short é igual ao INT porem com menos bits(range menor)

            switch (res){ //No switch a cada passo deve se colocar um break e ter uma opção default!!!

                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break; // Essa opção sai do programa, ele pede um parametro e 0 é como um sucesso!!
                default: Menu(); break;
            }

        }

        static void Soma(){
            Console.Clear();// Realiza a limpa em nosso terminal

            Console.WriteLine("Primeiro valor: "); // Joga o primeiro valor na tela
            float v1 = float.Parse(Console.ReadLine()); // É igual ao input do python, porem sempre retorna como uma string dessa forma usamos o Parse

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoSoma = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultadoSoma}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){

            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 =  float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo Valor:");
            float v2 =  float.Parse(Console.ReadLine());            

            Console.WriteLine("");

            float resultadoSubtracao = v1 - v2;

            Console.WriteLine($"O resultado da subtração é: {resultadoSubtracao}");
            Console.ReadKey();
            Menu();            
        }

        static void Divisao(){

            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultadoDivisao = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {resultadoDivisao}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao(){

            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoMultiplicacao = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é : {resultadoMultiplicacao}");
            Console.ReadKey();
            Menu();
        }
    }
}
