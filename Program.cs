using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja fazer");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Fatorial");
            Console.WriteLine("6- Elevado");
            Console.WriteLine("7- Raiz");
            Console.WriteLine("8- Sair");


            switch (short.Parse(Console.ReadLine()))
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multipicacao(); break;
                case 4: Divisao(); break;
                case 5: Fatorial(); break;
                case 6: Elevado(); break;
                case 7: Raiz(); break;
                case 8: Sair(); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("O resultado da soma é: " + resultado);
            // Console.WriteLine($"O resultado da soma é :{resultado}");
            // Console.WriteLine($"O resultado da soma é :{v1 + v2}");
            // Console.WriteLine("O resultado da soma é :" + (v1 + v2));
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine("O resultado da subtração é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Multipicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine("O resultado da multiplicação é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine("O resultado da divisão é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Fatorial()
        {

            int i;
            int fact = 1;
            int number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
            Console.ReadLine();
            Menu();

        }
        static void Elevado()
        {
            int numero;
            int elevado;
            int i;
            int resultado = 1;

            Console.Clear();
            Console.WriteLine("Digite o numero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o elevado");
            elevado = int.Parse(Console.ReadLine());

            for (i = 1; i <= elevado; i++)
            {
                resultado = resultado * numero;
            }
            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadLine();
            Menu();
        }
        static void Raiz()
        {
            Console.Clear();

            double numero;


            Console.WriteLine("Digite o numero que deseja saber a raiz");
            numero = float.Parse(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(numero));

            Console.ReadKey();
            Menu();

        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado!!!");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }

}
