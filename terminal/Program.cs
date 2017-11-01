using System;
using System.IO;
using dados;
using util;

namespace terminal
{
    class Program
    {
        static void Main(string[] args)
        {   
            string opcao1 = "";
            StreamWriter cadastro = new StreamWriter ("Cadastro.csv", true);
            do
            {
                Console.WriteLine("Digite a opção");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Depositar e Sacar");
                Console.WriteLine("3 - Obter Saldo");
                Console.WriteLine("4 - Sair");
                opcao1 = Console.ReadLine();
                switch(opcao1)
                {   
                    case "1":Cliente cliente1 = new Cliente();
                    cliente1.cadastrar();
                        break;
                    case "2":Conta conta1 = new Conta();
                    conta1.opcao();
                        break;
                    case "3":Conta conta2 = new Conta();
                    conta2.Meusaldo();
                        break;
                    case "4":Console.WriteLine("Deseja realmente sair(s ou n)");
                            string sair = Console.ReadLine();
                            if(sair.ToLower().Contains("s"))
                                Environment.Exit(0);
                            else if(!sair.ToLower().Contains("n"))    
                            {
                                opcao1 = "0";
                                Console.WriteLine("Opção Inválida");
                            }
                            else
                            {
                                opcao1 = "0";
                            } 
                            break;
                }   
            }
            while(opcao1 != "4");
        }
    }
}
