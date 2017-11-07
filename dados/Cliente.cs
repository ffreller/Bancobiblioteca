using System;
using util;
using dados;
using System.IO;

namespace dados{
    public class Cliente{
        public void cadastrar()
        {   
            string fisicajuridica = "";
            string cpf = "";
            string cnpj = "";
            string nome = "";
            StreamWriter cadastro = new StreamWriter("Cadastro.csv", true);
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
                            conta.banco = 1234;
                            conta.agencia = 9876;
                            conta.contacorrente = 4567;
                            conta.saldo = 300;
                            cadastro.WriteLine(nome + ";" + cpf + ";" + conta.banco + ";" + conta.agencia + ";" + conta.contacorrente + ";" + conta.saldo + ";");
                            cadastro.Close();
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
                            conta.banco = 1234;
                            conta.agencia = 9876;
                            conta.contacorrente = 4567;
                            conta.saldo = 300;
                            cadastro.WriteLine(nome + ";" + cnpj + ";" + conta.banco + ";" + conta.agencia + ";" + conta.contacorrente + ";" + conta.saldo + ";");
                            cadastro.Close();

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
            }
            while(fisicajuridica != "1" && fisicajuridica != "2" && fisicajuridica != "3");
        }
    }
}
