using ProcessadoraDeCartao.Core.Domain.Dto;

namespace ProcessadoraDeCartao.Core.Domain.Interface
{
    public interface IMesaDeCreditoService
    {
        bool EnviarParaMesaDeCredito(MesaDeCreditoRequest solicitacaoCartaoDeCredito);
    }
}
