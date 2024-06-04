using ViaCep_Api.Integracao.Response;

namespace ViaCep_Api.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}
