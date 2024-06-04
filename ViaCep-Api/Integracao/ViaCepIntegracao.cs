using ViaCep_Api.Integracao.Interfaces;
using ViaCep_Api.Integracao.Refit;
using ViaCep_Api.Integracao.Response;

namespace ViaCep_Api.Integracao;

public class ViaCepIntegracao:IViaCepIntegracao
{
    private readonly IViaCep viaCep;


    public ViaCepIntegracao(IViaCep viaCep)
    {
        this.viaCep = viaCep;
    }
    public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
            var resposta = await viaCep.ObterDadosViaCep(cep);

            if (resposta != null && resposta.IsSuccessStatusCode)
            {
                return resposta.Content;
            }

            return null;
        }
}