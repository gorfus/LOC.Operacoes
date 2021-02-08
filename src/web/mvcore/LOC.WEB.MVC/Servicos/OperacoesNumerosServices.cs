using LOC.WEB.MVC.Models;
using LOC.WEB.MVC.Setup;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace LOC.WEB.MVC.Servicos
{
    public interface IOperacoesNumerosServices
    {
        Task<NumeroViewModel> RetornarDivisoresComNumerosPrimos(int num);
        Task<NumeroViewModel> RetornarDivisores(int num);
    }

    public class OperacoesNumerosServices : IOperacoesNumerosServices
    {
        private readonly HttpClient _httpClient;

        public OperacoesNumerosServices(HttpClient httpClient,
                                   IOptions<AppSettings> settings)
        {
            httpClient.BaseAddress = new Uri(settings.Value.ApiOperacoes);

            _httpClient = httpClient;
        }

        public async Task<NumeroViewModel> RetornarDivisoresComNumerosPrimos(int valor)
        {
            var response = await _httpClient.GetAsync($"/api/operacoes/retornar-divisores-com-numeros-primos/{valor}");

            if (!response.IsSuccessStatusCode)
                return null;

            return JsonSerializer.Deserialize<NumeroViewModel>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<NumeroViewModel> RetornarDivisores(int valor)
        {
            var response = await _httpClient.GetAsync($"/api/operacoes/retornar-divisores/{valor}");

            if (!response.IsSuccessStatusCode)
                return null;

            return JsonSerializer.Deserialize<NumeroViewModel>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }


    }
}
