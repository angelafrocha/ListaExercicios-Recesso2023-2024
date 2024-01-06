using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class ValidacaoSenha
    {
        public static bool ValidaSenha(string senha)
        {
            if (senha.Length < 8)
            {
                return false;
            }

            bool temMaiuscula = false;
            bool temMinuscula = false;
            bool temNumero = false;

            for (int i = 0; i < senha.Length; i++)
            {
                if (senha[i] >= 'A' && senha[i] <= 'Z')
                {
                    temMaiuscula = true;
                }
                else if (senha[i] >= 'a' && senha[i] <= 'z')
                {
                    temMinuscula = true;
                }
                else if (senha[i] >= '0' && senha[i] <= '9')
                {
                    temNumero = true;
                }
            }

            return temMaiuscula && temMinuscula && temNumero;
        }
    }
}
