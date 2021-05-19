namespace ProcessadoraDeCartao.Core.Domain.Dto
{
    public class MesaDeCreditoRequest
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Profissao { get; set; }
        public decimal Renda { get; set; }
        public string NomeNoCartao { get; set; }
    }
}
