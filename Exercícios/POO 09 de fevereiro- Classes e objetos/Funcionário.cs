using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO_09_de_fevereiro__Classes_e_objetos
{
    public class Funcionário
    {
        public int codigo;
        public string nome;
        public DateTime Nascimento;
        

        public int CalculaIdade()
        {
            int idade = (int)DateTime.Now.Subtract(Nascimento).TotalDays / 365;
            return idade;
        }
    }
}
