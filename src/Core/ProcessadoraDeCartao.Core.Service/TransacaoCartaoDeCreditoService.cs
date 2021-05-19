using Core.CartaoDeCredito.Domain.Interface;
using FluentValidation;
using ProcessadoraDeCartao.Core.Domain;
using ProcessadoraDeCartao.Core.Domain.Dto;
using ProcessadoraDeCartao.Core.Domain.Interface;

namespace ProcessadoraDeCartao.Core.Service
{
    public class TransacaoCartaoDeCreditoService : ITransacaoCartaoDeCreditoService
    {
        private readonly ITransacaoCartaoDeCreditoRepository _transacaoCartaoDeCreditoRepository;
        private readonly IValidator<TransacaoCartaoDeCredito> _transacaoCartaoDeCredito;

        public TransacaoCartaoDeCreditoService(ITransacaoCartaoDeCreditoRepository transacaoCartaoDeCreditoRepository, IValidator<TransacaoCartaoDeCredito> transacaoCartaoDeCredito)
        {
            _transacaoCartaoDeCreditoRepository = transacaoCartaoDeCreditoRepository;
            _transacaoCartaoDeCredito = transacaoCartaoDeCredito;
        }

        public TransacaoCartaoDeCreditoResponse Criar(TransacaoCartaoDeCreditoRequest transacao)
        {
            throw new System.NotImplementedException();
        }
    }
}
