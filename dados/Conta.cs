using System;
using System.IO;
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
            Console.WriteLine("Qual é teu CPF/CNPJ?");
            string cpfcnpj = Console.ReadLine();
            StreamReader Leitor = new StreamReader("Cadastro.csv");
            string[] array = {};
            string linha;
            bool achou = false;
            do
            {
                linha = Leitor.ReadLine();
                if(linha != null)
                    {array = linha.Split(';');}
                else {opcao();}
                if(array[1] == cpfcnpj)
                {
                    achou = true;
                    break;
                }
            }
            while(array[0] != null);
            if(achou == true)
                {
                    saldo = Convert.ToDouble(array[5]);
                    saldo -= valor;
                    Console.WriteLine("Seu novo saldo é: " + saldo);
                }
            else
                {
                    Console.WriteLine("CPF Não Encontrado");
                    opcao();
                }
                
        }

        public void Depositar(double valor)
        {
            Console.WriteLine("Qual é teu CPF/CNPJ?");
            string cpfcnpj = Console.ReadLine();
            StreamReader Leitor = new StreamReader("Cadastro.csv");
            string[] array = {};
            string linha;
            bool achou = false;
            do
            {
                linha = Leitor.ReadLine();
                if(linha != null)
                    {array = linha.Split(';');}
                else {opcao();}
                if(array[1] == cpfcnpj)
                {
                    achou = true;
                    break;
                }
            }
            while(array[0] != null);
            if(achou == true)
                {
                    saldo = Convert.ToDouble(array[5]);
                    saldo += valor;
                    Console.WriteLine("Seu novo saldo é: " + saldo);
                }
            else
                {
                    Console.WriteLine("CPF Não Encontrado");
                    opcao();
                }
        }

        public void Meusaldo()
        {
            Console.WriteLine("Qual é teu CPF/CNPJ?");
            string cpfcnpj = Console.ReadLine();
            StreamReader Leitor = new StreamReader("Cadastro.csv");
            string[] array = {};
            string linha;
            bool achou = false;
            do
            {
                linha = Leitor.ReadLine();
                if(linha != null)
                    {array = linha.Split(';');}
                else{
                    achou = false;
                    break;
                    }
                if(array[1] == cpfcnpj)
                {
                    achou = true;
                    break;
                }
            }
            while(linha != null);
            if(achou == true)
            {
                saldo = Convert.ToDouble(array[5]);
                Console.WriteLine("Seu saldo é: " + saldo);
            }
            else
            {
                Console.WriteLine("CPF Não Encontrado");
            }
        }
    
    }
}
