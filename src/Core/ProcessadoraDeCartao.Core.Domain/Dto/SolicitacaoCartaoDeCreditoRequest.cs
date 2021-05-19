using FluentValidation.Results;
using System;

namespace ProcessadoraDeCartao.Core.Domain.Dto
{
    public class SolicitacaoCartaoDeCreditoRequest
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Profissao { get; set; }
        public decimal Renda { get; set; }
        public string NomeNoCartao { get; set; }
    }

    public class SolicitacaoCartaoDeCreditoResponse
    {
        public Guid? Id { get; set; }
        public string NumeroDoCartao { get; set; }
        public string Cvv { get; set; }
        public string DataDeValidade { get; set; }
        public string NomeNoCartao { get; set; }
        public ValidationResult Validation { get; set; }

    }

    public static class SolicitacaoCartaoDeCreditoRequestResponseMappingExtension
    {
        public static SolicitacaoCartaoDeCredito ToDomain(this SolicitacaoCartaoDeCreditoRequest solicitacaoCartaoDeCredito)
        {
            return new SolicitacaoCartaoDeCredito();
        }

        public static SolicitacaoCartaoDeCreditoResponse ToResponse(this SolicitacaoCartaoDeCredito solicitacaoCartaoDeCredito, CriarSolicitacaoAdquirenteResponse criarSolicitacaoAdquirenteResponse)
        {
            return new SolicitacaoCartaoDeCreditoResponse();
        }
    }
}
