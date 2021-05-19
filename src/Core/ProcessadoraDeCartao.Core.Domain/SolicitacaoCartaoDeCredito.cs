using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace ProcessadoraDeCartao.Core.Domain
{
    public class SolicitacaoCartaoDeCredito
    {
        public ValidationResult ValidationResult { get; set; }
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Profissao { get; set; }
        public decimal Renda { get; set; }
        public string NomeNoCartao { get; set; }
        public Enum TipoCartaoDisponivel { get; set; }
        public bool EnviadoParaMesaDeCredito { get; set; }

    }

    public class SolicitacaoCartaoDeCreditoValidator : AbstractValidator<SolicitacaoCartaoDeCredito>
    {
        private static IReadOnlyDictionary<string, string> _erroMsg => new Dictionary<string, string>()
        {
            {"erro_nome", "Insira um nome válido"},
            {"erro_cpf", "Insira um cpf válido"},
            {"erro_cpf_cadastrado", "Cpf já cadastrado"},
            {"erro_rg", "Insira um RG válido"},
            {"erro_profissao", "Insira uma profissão válida"},
            {"erro_nome_cartao", "Insira um nome no cartão válido"},
        };

        public static IReadOnlyDictionary<string, string> Erro_Msg => _erroMsg;

        public SolicitacaoCartaoDeCreditoValidator()
        {
        }
    }
}
