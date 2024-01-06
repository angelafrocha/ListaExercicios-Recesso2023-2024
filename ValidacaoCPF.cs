using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class ValidacaoCPF
    {
        public static bool ValidarCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }

            for (int i = 0; i < 9; i++)
            {
                if (cpf[i] < '0' || cpf[i] > '9')
                {
                    return false;
                }
            }

            int digitoVerificador = 0;
            for (int i = 0; i < 9; i++)
            {
                digitoVerificador += (i + 1) * int.Parse(cpf[i].ToString());
            }
            digitoVerificador = 11 - digitoVerificador % 11;

            if (digitoVerificador != int.Parse(cpf[9].ToString()))
            {
                return false;
            }

            return true;
        }
    }
}
