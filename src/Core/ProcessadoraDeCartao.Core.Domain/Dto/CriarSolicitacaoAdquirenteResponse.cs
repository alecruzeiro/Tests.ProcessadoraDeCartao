using System;

namespace ProcessadoraDeCartao.Core.Domain.Dto
{
    public class CriarSolicitacaoAdquirenteResponse
    {
        public string NumeroDoCartao { get; set; }
        public string Cvv { get; set; }
        public DateTime? DataDeValidade { get; set; }
        public string NomeNoCartao { get; set; }
    }
}
