using FluentValidation;
using FluentValidation.Results;
using System;

namespace ProcessadoraDeCartao.Core.Domain
{
    public class TransacaoCartaoDeCredito
    {
        public Guid Id { get; set; }
        public CartaoDeCredito CartaoDeCredito { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusTransacao StatusTransacao { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }

    public class TransacaoCartaoDeCreditoValidator : AbstractValidator<TransacaoCartaoDeCredito>
    {
        public TransacaoCartaoDeCreditoValidator()
        {
        }
    }
}
