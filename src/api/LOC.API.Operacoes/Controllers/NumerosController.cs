using LOC.Operacoes.Numeros.Entidades;
using LOC.Operacoes.Numeros.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOC.API.Operacoes.Controllers
{
    [ApiController]
    [Route("api/operacoes")]
    public class NumerosController : ControllerBase
    {
        private readonly INumeroOperacoes _numeroOperacoes;

        public NumerosController(INumeroOperacoes numeroOperacoes)
        {
            _numeroOperacoes = numeroOperacoes;
        }

        [HttpGet("retornar-divisores-com-numeros-primos/{valor:int}")]
        public async Task<IActionResult> RetornarDivisoresComNumerosPrimos(int valor)
        {
            try
            {
                var numero = new Numero(valor);
                _numeroOperacoes.RetornarDivisoresComNumerosPrimos(numero);

                return Ok(numero);
            }
            catch (Exception ex)
            {
                return BadRequest(new Dictionary<string, string> { { "Erro[RetornarDivisoresComNumerosPrimos]", ex.Message } });
            }
        }

        [HttpGet("retornar-divisores/{valor:int}")]
        public async Task<IActionResult> RetornarDivisores(int valor)
        {
            try
            {
                var numero = new Numero(valor);
                _numeroOperacoes.RetornarDivisores(numero);

                return Ok(numero);
            }
            catch (Exception ex)
            {
                return BadRequest(new Dictionary<string, string> { { "Erro[RetornarDivisores]", ex.Message } });
            }
        }
    }
}
