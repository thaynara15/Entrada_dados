using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrada_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome; //Tipo texto
            int idade; //Tipo numerico

            Console.Write("Insira o seu nome: ");
            nome = Console.ReadLine(); //Ler uma linha e atribuir a variável

            Console.Write("Insira sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());
            //Convert.ToInt16() Converte um valor em inteiro

            //Console.WriteLine(nome); //Exibe o valor da variável

            Console.WriteLine("Nome: " + nome + " idade: " + idade);

            Console.ReadKey(); //Aguarda o usuário precionar uma tecla
        }
    }
}
