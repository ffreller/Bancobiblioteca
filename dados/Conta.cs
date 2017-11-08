using System;
using System.IO;
using dados;
using NetOffice.ExcelApi;

namespace dados //library
{
    public class Conta
    {
    public double banco ()
    {
        Random random = new Random();
        return random.Next(10,99);
    }

    public double agencia ()
    {
        Random random = new Random();
        return random.Next(1000,9999);
    }

    public double contacorrente ()
    {
        Random random = new Random();
        return random.Next(1000,9999);
    }

    public double saldo ()
    {
        Random random = new Random();
        return random.Next(100,9999);
    }
        public double valor { get; set; }

        Application ex = new Application();

    

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
                Depositar(valor2);
                    break;

            }
        }while(escolha != "1" && escolha != "2");
    }
        public void Sacar(double valor)
        {
            Console.WriteLine("Qual é teu CPF/CNPJ?");
            string cpfcnpj = Console.ReadLine();
            double cpfcnpj1 = Convert.ToDouble(cpfcnpj);
            int contador = 1;
            bool achou = false;
            ex.DisplayAlerts = false;
            ex.Workbooks.Open(@"C:\Users\40809588897\Desktop\Programar\Semana6\Bancobiblioteca\clientes.xls");
            do
            {
                if (cpfcnpj1 == Convert.ToDouble(ex.Cells[contador,2].Value))
                {
                    achou = true;
                    break;
                }
                contador += 1;
            }
            while (ex.Cells[contador,1].Value != null);
            if(achou == true)
                {
                    double saldo1 = Convert.ToDouble(ex.Cells[contador,6].Value);
                    saldo1 -= valor;
                    ex.Cells[contador,6].Value = saldo1;
                    ex.ActiveWorkbook.Save();
                    ex.Quit();
                    ex.Dispose();
                    Console.WriteLine("Seu novo saldo é: " + saldo1);
                }
            else
                {
                    Console.WriteLine("CPF Não Encontrado");
                    ex.Quit();
                    ex.Dispose();
                    opcao();
                }                
        }

        public void Depositar(double valor)
        {
            Console.WriteLine("Qual é teu CPF/CNPJ?");
            string cpfcnpj = Console.ReadLine();
            double cpfcnpj1 = Convert.ToDouble(cpfcnpj);
            int contador = 1;
            bool achou = false;
            ex.DisplayAlerts = false;
            ex.Workbooks.Open(@"C:\Users\40809588897\Desktop\Programar\Semana6\Bancobiblioteca\clientes.xls");   
            do
            {
                if (cpfcnpj1 == Convert.ToDouble(ex.Cells[contador,2].Value))
                {
                    achou = true;
                    break;
                }
                contador += 1;
            }
            while (ex.Cells[contador,1].Value != null);
            if(achou == true)
            {
                double saldo1 = Convert.ToDouble(ex.Cells[contador,6].Value);
                saldo1 += valor;
                ex.Cells[contador,6].Value = saldo1;
                ex.ActiveWorkbook.Save();
                ex.Quit();
                ex.Dispose();
                Console.WriteLine("Seu novo saldo é: " + saldo1);
            }
            else
            {
                Console.WriteLine("CPF Não Encontrado");
                ex.Quit();
                ex.Dispose();
                opcao();
            } 
        }                  

        public void Meusaldo()
        {
            Console.WriteLine("Qual é teu CPF/CNPJ?");
            string cpfcnpj = Console.ReadLine();
            double cpfcnpj1 = Convert.ToDouble(cpfcnpj);
            int contador = 1;
            bool achou = false;
            ex.DisplayAlerts = false;
            ex.Workbooks.Open(@"C:\Users\40809588897\Desktop\Programar\Semana6\Bancobiblioteca\clientes.xls");
            do
            {
                if (cpfcnpj1 == Convert.ToDouble(ex.Cells[contador,2].Value))
                {
                    achou = true;
                    break;
                }
                contador += 1;
            }
            while (ex.Cells[contador,1].Value != null);
            if(achou == true)
            {
                double saldo1 = Convert.ToDouble(ex.Cells[contador,6].Value);
                Console.WriteLine("Seu saldo é: " + saldo1);
            }
            else
            {
                Console.WriteLine("CPF Não Encontrado");
                opcao();
            }
            ex.Quit();
            ex.Dispose(); 
        }
    
    }
}
