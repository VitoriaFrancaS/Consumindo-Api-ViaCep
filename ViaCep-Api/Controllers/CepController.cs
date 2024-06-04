using Microsoft.AspNetCore.Mvc;
using ViaCep_Api.Integracao.Interfaces;
using ViaCep_Api.Integracao.Response;

namespace ViaCep_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CepController : ControllerBase
{
    private readonly IViaCepIntegracao _integracao;

    public CepController(IViaCepIntegracao integracao)
    {
        _integracao = integracao;
    }

    [HttpGet("{cep}")]
    public async Task<ActionResult<ViaCepResponse>> ListarEnderecos(string cep)
    {
        var resposta = await _integracao.ObterDadosViaCep(cep);
        if (resposta == null)
        {
            return BadRequest("CEP não encontrado");
        }
        return Ok(resposta);
    }
}
