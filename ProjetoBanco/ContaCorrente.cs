using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente, double saldo, int numero) : base(cliente, saldo, numero)
        {
        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor + 0.2);
        }


    }
}
