using FluentValidation.Results;
using System;

namespace ProcessadoraDeCartao.Core.Domain.Dto
{
    public class TransacaoCartaoDeCreditoRequest
    {
        public CartaoDeCreditoRequest CartaoDeCredito { get; set; }
        public decimal ValorTotal { get; set; }
    }

    public class TransacaoCartaoDeCreditoResponse
    {
        public Guid? Id { get; set; }
        public StatusTransacao StatusTransacao { get; set; }
        public ValidationResult Validation { get; set; }
    }

    public class CartaoDeCreditoRequest
    {
        public string NomeNoCartao { get; set; }
        public string NumeroCartaoVirtual { get; set; }
        public string Cvv { get; set; }
        public string DataDeValidade { get; set; }
        public string Cpf { get; set; }
    }


    public static class TransacaoCartaoDeCreditoResponseMappingExtension
    {
        public static TransacaoCartaoDeCredito ToDomain(this TransacaoCartaoDeCreditoRequest solicitacaoCartaoDeCredito)
        {
            return new TransacaoCartaoDeCredito();
        }

        public static TransacaoCartaoDeCreditoResponse ToResponse(this TransacaoCartaoDeCredito solicitacaoCartaoDeCredito)
        {
            return new TransacaoCartaoDeCreditoResponse();
        }
    }
}
