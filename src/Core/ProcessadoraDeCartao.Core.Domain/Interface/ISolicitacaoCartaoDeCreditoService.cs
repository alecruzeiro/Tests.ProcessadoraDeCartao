using ProcessadoraDeCartao.Core.Domain.Dto;

namespace ProcessadoraDeCartao.Core.Domain.Interface
{
    public interface ISolicitacaoCartaoDeCreditoService
    {
        public SolicitacaoCartaoDeCreditoResponse SolicitarCartao(SolicitacaoCartaoDeCreditoRequest solicitacaoCartaoDeCreditoRequest);
        public bool VerificarCpfJaCadastrado(string cpf);
    }
}
