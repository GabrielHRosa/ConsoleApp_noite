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

        public string getDescricao()
        {
            return Descricao;
        }

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public decimal getValor() {
            return Valor; 
        }

        public void setValor(decimal valor)
        {
            Valor = valor;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id) 
        { 
            Id = id;
        }

        public string ExibirDados()
        {
            return "ID: " + Id + " Valor: " + Valor + " Produto: " + Descricao;
        }

    }
}
