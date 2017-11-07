using System;
using dados;

namespace dados //library
{
    public class Conta
    {
        public int banco { get; set; }
        public int agencia { get; set; }
        public int contacorrente { get; set; }
        public double saldo { get; set; }
        public double valor { get; set; }

    public void opcao()
    {
        string escolha = "";
        do
        {
            Console.WriteLine("Sacar (digite 1), depositar (digite 2)");
            escolha = Console.ReadLine();
            switch(escolha)
            {  
                case "1": Console.WriteLine("Quanto deseja sacar?");
                string valo = Console.ReadLine();
                double valor1 = Convert.ToDouble(valo);
                Sacar(valor1);
                    break;
                case "2": Console.WriteLine("Quanto deseja depositar?");
                string val = Console.ReadLine();
                double valor2 = Convert.ToDouble(val);
                Sacar(valor2);
                    break;

            }
        }while(escolha != "1" && escolha != "2");
    }
        public void Sacar(double valor)
        {
            saldo -= valor;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public double Meusaldo()
        {
            Console.WriteLine("Qual é teu CPF/CNPJ?");
            string cpfcnpj = Console.ReadLine();
            return saldo;
        }
    
    }
}
