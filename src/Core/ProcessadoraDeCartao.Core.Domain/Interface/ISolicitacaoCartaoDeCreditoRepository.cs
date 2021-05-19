using ProcessadoraDeCartao.Core.Domain.Dto;

namespace ProcessadoraDeCartao.Core.Domain.Interface
{
    public interface ISolicitacaoCartaoDeCreditoRepository
    {
        public bool VerificarCpfJaCadastrado(string cpf);
        public CriarSolicitacaoAdquirenteResponse CriarSolicitacaoAdquirente(SolicitacaoCartaoDeCredito solicitacaoCartaoDeCredito);
    }
}
