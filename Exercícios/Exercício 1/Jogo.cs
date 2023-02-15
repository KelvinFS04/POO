using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Jogo
    {
        private int código;
        private string nome;
        private string categoria;
        private DateTime data_de_lançamento;

        public int GetCódigo() => código;
        public void setCódigo(int código)
        {
            if (código <= 0)
            {
                throw new Exception("Código não pode ser menor que 0 (zero)");
            }
            else
            {
                this.código = código;
            }
        }
        public string GetNome() => nome;
        public void setNome(string nome) 
        {
            if (string.IsNullOrEmpty(nome)
            {
                
            }
            else
            {
                this.nome = nome;
            }
        }
        public string GetCategoria() => categoria;
        public DateTime GetData_de_lançamento() => data_de_lançamento;

    }
}
