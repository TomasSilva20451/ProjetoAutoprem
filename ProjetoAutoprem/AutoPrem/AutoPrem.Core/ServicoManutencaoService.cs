// AutoPrem.Core/Services/ServicoManutencaoService.cs
using System;

namespace AutoPrem.Core.Services
{
    public class ServicoManutencaoService
    {
        private ServicoManutencao _servicoManutencao;

        public ServicoManutencaoService(ServicoManutencao servicoManutencao)
        {
            _servicoManutencao = servicoManutencao;
        }

        #region Métodos

        public bool AgendarManutencao()
        {
            if (!_servicoManutencao.Realizado)
            {
                Console.WriteLine($"Agendando serviço de manutenção para {_servicoManutencao.DataAgendamento.ToShortDateString()}: {_servicoManutencao.Descricao}");
                // TODO: Implementar lógica de agendamento de manutenção
                _servicoManutencao.Realizado = true;
                return true;
            }
            else
            {
                Console.WriteLine($"O serviço de manutenção já foi realizado em {_servicoManutencao.DataAgendamento.ToShortDateString()}: {_servicoManutencao.Descricao}");
                return false;
            }
        }

        public void RealizarManutencao(Componente componente)
        {
            componente.RealizarManutencao();
            // TODO: Implementar lógica de realização de manutenção no serviço
        }
        #endregion
    }
}
