using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.Exercicios
{
    class Basicos
    {
        public void Exercicio1()
        {
            Console.WriteLine("Hello\nJoão Ulisses!");
        }

        public void Exercicio2()
        {
            int n1 = 5;
            int n2 = 2;
            Console.WriteLine("A soma entre {0} e {1} = {2}", n1, n2, n1+n2);
        }

        public void Exercicio3()
        {
            double n1 = 20;
            double n2 = 10;
            
            Console.WriteLine("Divisão entre {0} e {1} = {3}", n1, n2, n1/n2);
        }
        
        public void Exercicio4()
        {
            Console.WriteLine(-1 + (4 * 6));
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + ((-4 * 6) / 11));
            Console.WriteLine(2 + (15 / (6 * 1)) - 7 % 2);
        }

        public void Exercicio5()
        {
            int numero1, numero2, temp;

            Console.Write("\nDigite o primeiro número : ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo número : ");
            numero2 = int.Parse(Console.ReadLine());

            temp = numero1;
            numero1 = numero2;
            numero2 = temp;

            Console.Write("\nApos trocar: numero 1 {0} | numero 2 {1}", numero1, numero2);
        }

        public void Exercicio6()
        {
            int numero1, numero2, numero3;

            Console.WriteLine("\nDigite o primeiro número :");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número :");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o terceiro número :");
            numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMultiplicação dos três números inseridos = {0}", numero1*numero2*numero3);
        }

        public void Exercicio7()
        {
            double numero1, numero2;

            Console.WriteLine("\nDigite o primeiro número :");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número :");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Adição entre {0} e {1} = {2}", numero1, numero2, numero1 + numero2);
            Console.WriteLine("Subtração entre {0} e {1} = {2}", numero1, numero2, numero1 - numero2);
            Console.WriteLine("Multiplicação entre {0} e {1} = {2}", numero1, numero2, numero1 * numero2);
            Console.WriteLine("Divisão entre {0} e {1} = {2}", numero1, numero2, numero1 / numero2);
            Console.WriteLine("Resto entre {0} e {1} = {2}", numero1, numero2, numero1 % numero2);
        }
        
        public void Exercicio8()
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero1, i, numero1*i);
            }
        }

        public void Exercicio9()
        {
            double notas;
            double somaNotas = 0;
            int quantidadeNotas = 4;

            for (int i = 1; i <= quantidadeNotas; i++)
            {
                Console.WriteLine("Digite o {0}: ", i);
                notas = double.Parse(Console.ReadLine());

                somaNotas += notas;

                if (i == quantidadeNotas)
                    Console.WriteLine("Media das notas = {0} ", somaNotas / quantidadeNotas);
            }
        }

        public void Exercicio()
        {
            int[] numero = new int[3];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Digite o {0} numero: ", i);
                numero[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("({0} + {1}) x {2} = {3}\n{0} x {1} + {1} x {2} = {4}"
                , numero[0], numero[1], numero[2]
                , (numero[0] + numero[1]) * numero[2]
                , (numero[0] * numero[1]) + (numero[1] * numero[2])
            );
        }
    }
}
