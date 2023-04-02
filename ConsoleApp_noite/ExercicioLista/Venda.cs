using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_noite.ExercicioLista
{
    public class Venda
    {
        public int IdVenda;
        public string DataVenda;
        public string IdProduto;
        public int Preco;
        public string Descricao;

        public string ExibirVenda()
        {
            return "Id Venda: " + IdVenda + " Data da Venda: " + DataVenda + " Preço: " + Preco + " Produto: " + Descricao;
        }
    }


}
