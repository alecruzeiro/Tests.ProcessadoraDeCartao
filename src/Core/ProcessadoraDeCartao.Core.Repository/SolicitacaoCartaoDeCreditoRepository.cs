using ProcessadoraDeCartao.Core.Domain;
using ProcessadoraDeCartao.Core.Domain.Dto;
using ProcessadoraDeCartao.Core.Domain.Interface;

namespace ProcessadoraDeCartao.Core.Repository
{
    public class SolicitacaoCartaoDeCreditoRepository : ISolicitacaoCartaoDeCreditoRepository
    {
        public CriarSolicitacaoAdquirenteResponse CriarSolicitacaoAdquirente(SolicitacaoCartaoDeCredito solicitacaoCartaoDeCredito)
        {
            throw new System.NotImplementedException();
        }

        public bool VerificarCpfJaCadastrado(string cpf)
        {
            throw new System.NotImplementedException();
        }
    }
}
