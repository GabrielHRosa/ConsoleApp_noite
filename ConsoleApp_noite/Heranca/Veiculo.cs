using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_noite.Heranca
{
    public class Veiculo
    {
        public int numeroAssento;
        public int numeroPortas;
        public bool temMotor;

        public string ExibirDados()
        {
            return "Numero Assentos: " + numeroAssento + " Numero de Portas: " + numeroPortas + " Tem Motor: " + temMotor;
        }
    }
}
