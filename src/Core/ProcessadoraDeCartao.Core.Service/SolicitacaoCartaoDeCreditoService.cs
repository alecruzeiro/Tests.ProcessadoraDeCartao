using FluentValidation;
using ProcessadoraDeCartao.Core.Domain;
using ProcessadoraDeCartao.Core.Domain.Dto;
using ProcessadoraDeCartao.Core.Domain.Interface;

namespace ProcessadoraDeCartao.Core.Service
{
    public class SolicitacaoCartaoDeCreditoService : ISolicitacaoCartaoDeCreditoService
    {
        private readonly ISolicitacaoCartaoDeCreditoRepository _solicitacaoCartaoDeCreditoRepository;
        private readonly IMesaDeCreditoService _mesaDeCreditoService;
        private readonly IValidator<SolicitacaoCartaoDeCredito> _solicitacaoCartaoDeCreditoValidator;

        public SolicitacaoCartaoDeCreditoService(ISolicitacaoCartaoDeCreditoRepository solicitacaoCartaoDeCreditoRepository, IMesaDeCreditoService mesaDeCreditoService, 
            IValidator<SolicitacaoCartaoDeCredito> solicitacaoCartaoDeCreditoValidator)
        {
            _solicitacaoCartaoDeCreditoRepository = solicitacaoCartaoDeCreditoRepository;
            _mesaDeCreditoService = mesaDeCreditoService;
            _solicitacaoCartaoDeCreditoValidator = solicitacaoCartaoDeCreditoValidator;
        }

        public SolicitacaoCartaoDeCreditoResponse SolicitarCartao(SolicitacaoCartaoDeCreditoRequest solicitacaoCartaoDeCreditoRequest)
        {
            throw new System.NotImplementedException();
        }

        public bool VerificarCpfJaCadastrado(string cpf)
        {
            throw new System.NotImplementedException();
        }
    }
}
