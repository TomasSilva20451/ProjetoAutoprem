/**
 * @file ServicoManutencao.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the ServicoManutencao class
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class ServicoManutencao
{
    #region Propriedades

    public DateTime DataAgendamento { get; }
    public string Descricao { get; private set; }
    public bool Realizado { get; private set; }

    #endregion

    #region Construtores

    public ServicoManutencao(DateTime dataAgendamento, string descricao)
    {
        DataAgendamento = dataAgendamento;
        Descricao = descricao;
        Realizado = false;
        // TODO: Inicializar outros atributos no construtor
    }

    #endregion

    #region Métodos

    public bool AgendarManutencao()
    {
        if (!Realizado)
        {
            Console.WriteLine($"Agendando serviço de manutenção para {DataAgendamento.ToShortDateString()}: {Descricao}");
            // TODO: Implementar lógica de agendamento de manutenção
            Realizado = true;
            return true;
        }
        else
        {
            Console.WriteLine($"O serviço de manutenção já foi realizado em {DataAgendamento.ToShortDateString()}: {Descricao}");
            return false;
        }
    }

    // Adicione mais métodos e propriedades conforme necessário
    public void RealizarManutencao(Componente componente)
    {
        componente.RealizarManutencao();
        // TODO: Implementar lógica de realização de manutenção no serviço
    }
    #endregion
}
