using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class Conta
    {
        public int Numero { get; set; }
        private double Saldo { get;set; }

        public double GetSaldo()
        {
            return Saldo;
        }

        public Cliente Cliente { get; set; }

        public Conta(Cliente cliente, double saldo, int numero)
        {
            Cliente = cliente;
            Saldo = saldo;
            Numero = numero;
        }
        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }
        public virtual void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public virtual void Transferir(Conta entrada, Conta saida, double valor)
        {
            entrada.Saldo -= valor;
            saida.Depositar(valor);
        }
    }
}
