using LOC.WEB.MVC.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace LOC.WEB.MVC.Setup
{
    public static class DI
    {
        public static void SetDI(this IServiceCollection services)
        {
            services.AddHttpClient<IOperacoesNumerosServices, OperacoesNumerosServices>();
        }
    }
}
