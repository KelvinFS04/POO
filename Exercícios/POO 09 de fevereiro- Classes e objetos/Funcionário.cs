using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO_09_de_fevereiro__Classes_e_objetos
{
    public class Funcionário
    {
        private int codigo;
        private string nome;
        private DateTime nascimento;
        private string cpf;


        public void SetCodigo(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Código não pode ser negativo");
            }
            else
            {
                codigo = valor;
            }
        }
        public int GetCodigo() 
        {
            return codigo;
        }
        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Informe o nome");
            }
            else
            {
                this.nome = nome;
            }
        }

        //Método de uma linha tipo "arrow"
        public string GetNome() => nome;
        public void SetDataNascimento(DateTime data) 
        {
            if (data > DateTime.Now) 
            {
                throw new Exception("Pessoa nem nasceu ainda...");
            }
            else
            {
                nascimento = data;
            }
        }
        public DateTime GetDataNascimento() => nascimento;
        public int calculaIdade()
        {
            int idade = (int)DateTime.Now.Subtract(nascimento).TotalDays / 365;
            return idade;
        }

        public string GetCPF() => cpf;
        public void SetCPF(string cpf)
        {
            this.cpf = cpf;
        }
    }
}
