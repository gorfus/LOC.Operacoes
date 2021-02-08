using LOC.WEB.MVC.Models;
using LOC.WEB.MVC.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LOC.WEB.MVC.Controllers
{
    public class OperacoesController : Controller
    {
        private readonly IOperacoesNumerosServices _operacoesNumerosServices;

        public OperacoesController(IOperacoesNumerosServices operacoesNumerosServices)
        {
            _operacoesNumerosServices = operacoesNumerosServices;
        }

        public async Task<NumeroViewModel> RetornarDivisores(int valor)
        {
            try
            {
                return await _operacoesNumerosServices.RetornarDivisores(valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<NumeroViewModel> RetornarDivisoresComNumerosPrimos(int valor)
        {
            try
            {
                return await _operacoesNumerosServices.RetornarDivisoresComNumerosPrimos(valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
