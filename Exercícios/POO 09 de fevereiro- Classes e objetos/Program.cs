using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_09_de_fevereiro__Classes_e_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionário f = new Funcionário();

            //revalida a condição na classe. Mais difícil de corrigir caso haja mudanças no código
            do
            {
                try
                {
                    Console.WriteLine("Digite o código: ");
                    f.SetCodigo(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (f.GetCodigo() <= 0);

            //melhor opção por já validar na própria classe
            do
            {
                try
                {
                    Console.WriteLine("Digite o nome: ");
                    f.SetNome(Console.ReadLine());
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.WriteLine("Digite o nome: ");
                    f.SetCPF(Console.ReadLine());
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.WriteLine("Digite o nome: ");
                    f.SetDataNascimento(Convert.ToDateTime(Console.ReadLine()));
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while(true);




            //outra entrada de dados

            /*Funcionário funcionário = new Funcionário();
            Console.WriteLine("Digite o código");
            funcionário.SetCodigo(Convert.ToInt32(Console.ReadLine())) ;
            Console.WriteLine("Digite o nome");
            funcionário.SetNome(Console.ReadLine());
            Console.WriteLine("Digite a data de nascimento");
            funcionário.SetDataNascimento(Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Digite o cpf");
            funcionário.SetCPF( Console.ReadLine());

            Console.WriteLine("\n\n Dados cadastrados\n\n");
            Console.WriteLine( $"Código: {funcionário.GetCodigo()} \nNome: {funcionário.GetNome()} " +
                $"\nNascimento: {funcionário.GetDataNascimento().ToShortDateString()}" +
                $"\nIdade: {funcionário.calculaIdade()}" );
            Console.ReadKey();
            */

        }
    }
}
