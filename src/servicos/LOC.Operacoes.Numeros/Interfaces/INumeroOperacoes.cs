using LOC.Operacoes.Numeros.Entidades;

namespace LOC.Operacoes.Numeros.Interfaces
{
    public interface INumeroOperacoes
    {
        void RetornarDivisores(Numero num);
        void RetornarDivisoresComNumerosPrimos(Numero num);
    }
}
