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
            //entrada de dados pré privatização dos atributos
            Funcionário funcionário = new Funcionário();
            Console.WriteLine("Digite o código");
            funcionário.codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome");
            funcionário.nome = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento");
            funcionário.nascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o cpf");
            funcionário.cpf = Console.ReadLine();

            Console.WriteLine("\n\n Dados cadastrados\n\n");
            Console.WriteLine( $"Código: {funcionário.codigo} \nNome: {funcionário.nome} " +
                $"\nNascimento: {funcionário.nascimento.ToShortDateString()}" +
                $"\nIdade: {funcionário.CalculaIdade()}" );
            Console.ReadKey();

        }
    }
}
