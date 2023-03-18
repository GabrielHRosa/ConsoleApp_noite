using ConsoleApp_noite.Heranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_noite.ExercicioLista
{
    public class Client : Venda
    {
        public string Nome;
        public string Telefone;
        public string Endereco;

        public string getExibirCliente()
        {
            return "Nome: " + Nome + " Telefone: " + Telefone + " Endereço: " + Endereco;
        }
    }
}
