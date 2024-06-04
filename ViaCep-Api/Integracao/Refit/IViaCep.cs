using Refit;
using ViaCep_Api.Integracao.Response;

namespace ViaCep_Api.Integracao.Refit;

public interface IViaCep
{

    [Get("/ws/{cep}/json")]

    Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
}
