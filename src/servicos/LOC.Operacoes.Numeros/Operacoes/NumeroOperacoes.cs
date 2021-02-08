using LOC.Operacoes.Numeros.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOC.Operacoes.Numeros.Interfaces
{
    public class NumeroOperacoes : INumeroOperacoes
    {
        public void RetornarDivisoresComNumerosPrimos(Numero num)
        {
            RetornarDivisores(num);
            RetornarNumerosPrimosDeDivisores(num);
        }

        public void RetornarDivisores(Numero num)
        {
            for (int i = 1; i <= num.Valor; i++)
            {
                if ((num.Valor % i) == 0)
                    num.AdicionarDivisor(i);
            }

        }

        public void RetornarNumerosPrimosDeDivisores(Numero num)
        {
            foreach (var divisor in num.Divisores)
            {
                var quantidadeDivisoes = 0;
                for (int i = 1; i <= divisor; i++)
                {
                    if ((divisor % i) == 0)
                        quantidadeDivisoes++;
                }

                if (quantidadeDivisoes == 2)
                    num.AdicionarDivisorPrimo(divisor);
            }
        }
    }
}
