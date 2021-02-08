using System.Collections.Generic;

namespace LOC.Operacoes.Numeros.Entidades
{
    public class Numero
    {
        public Numero(int valor)
        {
            Valor = valor;
            Divisores = new List<int>();
            DivisoresPrimos = new List<int>();
        }
        public int Valor { get; private set; }
        public List<int> Divisores { get; private set; }
        public List<int> DivisoresPrimos { get; private set; }

        public void AdicionarDivisor(int valor) { Divisores.Add(valor); }
        public void AdicionarDivisorPrimo(int valor) { DivisoresPrimos.Add(valor); }

        public bool Validar()
        {
            if (Valor <= 1)
                return false;

            return true;
        }
    }
}
