using ProcessadoraDeCartao.Core.Domain.Dto;

namespace ProcessadoraDeCartao.Core.Domain.Interface
{
    public interface ITransacaoCartaoDeCreditoService
    {
        TransacaoCartaoDeCreditoResponse Criar(TransacaoCartaoDeCreditoRequest transacao);
    }
}
