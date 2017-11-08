using System;
using util;
using dados;
using System.IO;
using NetOffice.ExcelApi;

namespace dados{
    public class Cliente{
        public void cadastrar()
        {
            string fisicajuridica = "";
            string cpf = "";
            string cnpj = "";
            string nome = "";
            Application ex = new Application();
            Conta conta = new Conta();
            
            do
            {
                Console.WriteLine("Pessoa física (1), pessoas juríridca (2)");
                fisicajuridica = Console.ReadLine();
                switch(fisicajuridica)
                {
                    case "1":
                        Console.WriteLine("Digite seu CPF");
                        cpf = Console.ReadLine();
                        Documento doc = new Documento();
                        do 
                        {
                            Console.WriteLine("Digite seu nome:");
                            nome = Console.ReadLine();
                            conta.banco();
                            conta.agencia();
                            conta.contacorrente();
                            conta.saldo();
                        }
                        while (doc.ValidarCPF(cpf) != true);     
                        break;
                    case "2":
                        Console.WriteLine("Digite seu CNPJF");
                        cnpj = Console.ReadLine();
                        Documento docc = new Documento();
                        do
                        {
                            Console.WriteLine("Digite seu nome:");
                            nome = Console.ReadLine();
                            conta.agencia ();
                            conta.contacorrente();
                            conta.saldo();

                        }
                        while(docc.ValidarCNPJ(cnpj) != true);
                        break;
                    case "3":
                        Console.WriteLine("Deseja realmente sair(s ou n)");
                        string sair = Console.ReadLine();
                        if(sair.ToLower().Contains("s"))
                            Environment.Exit(0);
                        else if(!sair.ToLower().Contains("n"))    
                        {
                            fisicajuridica = "0";
                            Console.WriteLine("Opção Inválida");
                        }
                        else
                        {
                            fisicajuridica = "0";
                        } 
                        break;
                }        
             if(!File.Exists(@"C:\Users\40809588897\Desktop\Programar\Semana6\Bancobiblioteca\clientes.xls"))
            {
                ex.Workbooks.Add();
                ex.Cells[1,1].Value = nome;
                ex.Cells[1,2].Value = cpf;
                ex.Cells[1,3].Value = conta.banco();
                ex.Cells[1,4].Value = conta.agencia();
                ex.Cells[1,5].Value = conta.contacorrente();
                ex.Cells[1,6].Value = conta.saldo();
                ex.ActiveWorkbook.SaveAs(@"C:\Users\40809588897\Desktop\Programar\Semana6\Bancobiblioteca\clientes.xls");
                ex.Quit();
                ex.Dispose();
            }
            else
            {
                ex.DisplayAlerts = false;
                ex.Workbooks.Open(@"C:\Users\40809588897\Desktop\Programar\Semana6\Bancobiblioteca\clientes.xls");
                int contador = 1;
                do
                {
                    contador += 1;
                } 
                while (ex.Cells[contador,1].Value != null);
                ex.Cells[contador,1].Value = nome;
                ex.Cells[contador,2].Value = cpf;
                ex.Cells[contador,3].Value = conta.banco();
                ex.Cells[contador,4].Value = conta.agencia();
                ex.Cells[contador,5].Value = conta.contacorrente();
                ex.Cells[contador,6].Value = conta.saldo();
                ex.ActiveWorkbook.Save();
                ex.Quit();
                ex.Dispose();
            }
            }
            while(fisicajuridica != "1" && fisicajuridica != "2" && fisicajuridica != "3");
        }
    }
}
