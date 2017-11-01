using System;

namespace dados
{
    public class Dados
    {
        public int banco { get; set; }
        public int agencia { get; set; }
        public int contacorrente { get; set; }
        public double saldo { get; set; }
        public double valor { get; set; }

        public void Sacar(double valor)
        {
            saldo -= valor;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            
        }
    }
}
