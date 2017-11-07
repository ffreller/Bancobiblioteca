using System;

namespace util{
    public class Documento{

        public bool ValidarCPF(string cpf)
        {
            
            if (cpf.Length != 11)
            {
                return false;
            }

            if(cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222"
             || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555"
             || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
            {
                return false;
            }

            int[] multiplicador1 = new int[9]{10,9,8,7,6,5,4,3,2};
            int[] multiplicador2 = new int[10]{11,10,9,8,7,6,5,4,3,2};
            string tempCpf, digito;
            int soma =0,resto =0;
            tempCpf = cpf.Substring(0,9);
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt16(tempCpf[i].ToString())  * multiplicador1[i];
            }
            resto = soma % 11;
            if(resto < 2)
                resto = 0;
            else
            {
                resto = 11 - resto;
            }
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt16(tempCpf[i].ToString())  * multiplicador2[i];
            }
            resto = soma % 11;
            if(resto < 2)
                {resto = 0;}
            else
                {resto = 11 - resto;}
            digito  =digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public bool ValidarCNPJ(string cnpj){

            if (cnpj.Length != 14){
                return false;
            }
            int[] multiplicador1 = new int[12]{5,4,3,2,9,8,7,6,5,4,3,2};
            int[] multiplicador2 = new int[13]{6,5,4,3,2,9,8,7,6,5,4,3,2};
            string tempCnpj, digito;
            int soma =0,resto =0;
            tempCnpj = cnpj.Substring(0,12);
            for (int i = 0; i < 12; i++)
            {
                soma += Convert.ToInt16(tempCnpj[i].ToString())  * multiplicador1[i];
            }
            resto = soma % 11;
            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
            {
                 soma += Convert.ToInt16(tempCnpj[i].ToString())  * multiplicador2[i];
            }
            resto = soma % 11;
            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}