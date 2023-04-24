using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(Cliente cliente, double saldo, int numero) : base(cliente, saldo, numero)
        {
        }

        public override void Sacar(double valor)
        {
            if (valor <= 1000)
            {
                base.Sacar(valor + 0.1);
            }
            else
            {
                MessageBox.Show("Valor acima do Permitido");
            }
        }


    }
}
