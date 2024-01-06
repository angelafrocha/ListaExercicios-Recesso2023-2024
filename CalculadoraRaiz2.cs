using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class CalculadoraRaiz2
    {
        public static double RaizQuadrada(double numero)
        {
            double raiz = 0.0;
            double epsilon = 0.000001;

            raiz = numero / 2.0;

            while (true)
            {
                double novaRaiz = (raiz + numero / raiz) / 2.0;

                if (Math.Abs(raiz - novaRaiz) < epsilon)
                {
                    break;
                }

                raiz = novaRaiz;
            }

            return raiz;
        }
    }
}
