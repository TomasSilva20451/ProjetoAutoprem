/**
 * @file ServicoManutencao.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the ServicoManutencao class
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class ServicoManutencao
{
    #region Properties

    public DateTime DataAgendamento { get; }
    public string Descricao { get; private set; }
    public bool Realizado { get; private set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ServicoManutencao"/> class.
    /// </summary>
    /// <param name="dataAgendamento">The data agendamento.</param>
    /// <param name="descricao">The descricao.</param>
    public ServicoManutencao(DateTime dataAgendamento, string descricao)
    {
        DataAgendamento = dataAgendamento;
        Descricao = descricao;
        Realizado = false;
        // TODO: Initialize other attributes in the constructor
    }

    #endregion

    #region Methods

    /// <summary>
    /// Agenda um serviço de manutenção.
    /// </summary>
    /// <returns>True se o serviço for agendado com sucesso; False se o serviço já tiver sido realizado.</returns>
    public bool AgendarManutencao()
    {
        if (!Realizado)
        {
            Console.WriteLine($"Agendando serviço de manutenção para {DataAgendamento.ToShortDateString()}: {Descricao}");
            // TODO: Implement maintenance scheduling logic
            Realizado = true;
            return true;
        }
        else
        {
            Console.WriteLine($"O serviço de manutenção já foi realizado em {DataAgendamento.ToShortDateString()}: {Descricao}");
            return false;
        }
    }

    // Add more methods and properties as needed

    #endregion
}
