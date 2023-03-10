using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_noite
{
    public class Produto
    {
        private int Id;
        private decimal Valor;
        private string Descricao;

        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        }
    }
}
