using LOC.Operacoes.Numeros.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LOC.API.Operacoes.Setup
{
    public static class DI
    {
        public static void SetDI(this IServiceCollection services)
        {
            services.AddScoped<INumeroOperacoes, NumeroOperacoes>();
        }
    }
}
