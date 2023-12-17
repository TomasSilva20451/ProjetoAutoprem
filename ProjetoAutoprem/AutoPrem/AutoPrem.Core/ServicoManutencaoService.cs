/**
 * @file ServicoManutencaoService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the ServicoManutencaoService class
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

namespace AutoPrem.Core.Services
{
    /// <summary>
    /// Serviço responsável por agendar e realizar manutenções.
    /// </summary>
    public class ServicoManutencaoService
    {
        private ServicoManutencao _servicoManutencao;

        /// <summary>
        /// Construtor da classe ServicoManutencaoService.
        /// </summary>
        /// <param name="servicoManutencao">Instância de ServicoManutencao associada ao serviço.</param>
        public ServicoManutencaoService(ServicoManutencao servicoManutencao)
        {
            _servicoManutencao = servicoManutencao;
        }

        #region Métodos

        /// <summary>
        /// Agenda uma manutenção se ainda não foi realizada.
        /// </summary>
        /// <returns>True se a manutenção foi agendada com sucesso; False se já foi realizada anteriormente.</returns>
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

        /// <summary>
        /// Realiza a manutenção utilizando um componente específico.
        /// </summary>
        /// <param name="componente">Componente a ser mantido.</param>
        public void RealizarManutencao(Componente componente)
        {
            componente.RealizarManutencao();
            // TODO: Implementar lógica de realização de manutenção no serviço
        }

        #endregion
    }
}
