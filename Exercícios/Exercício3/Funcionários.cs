using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    internal class Funcionários
    {
        private int id;
        private string nome;
        private string rg;
        private double salário;

        public int getId() => id;
        public string getNome() => nome;
        public string getRg() => rg;
        public double getSalário() => salário;

        public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("O id não pode ser menor ou igual a zero");
            }
            else
            {
                this.id = id;
            }

        }


    }
}
