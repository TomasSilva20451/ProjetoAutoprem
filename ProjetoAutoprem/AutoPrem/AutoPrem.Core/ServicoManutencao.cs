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

    /// <summary>
    /// Data de agendamento do serviço de manutenção.
    /// </summary>
    public DateTime DataAgendamento { get; }

    /// <summary>
    /// Descrição do serviço de manutenção.
    /// </summary>
    public string Descricao { get; private set; }

    /// <summary>
    /// Indica se o serviço de manutenção foi realizado.
    /// </summary>
    public bool Realizado { get; set; }

    #endregion

    #region Construtores

    /// <summary>
    /// Construtor da classe ServicoManutencao.
    /// </summary>
    /// <param name="dataAgendamento">Data de agendamento do serviço.</param>
    /// <param name="descricao">Descrição do serviço.</param>
    public ServicoManutencao(DateTime dataAgendamento, string descricao)
    {
        DataAgendamento = dataAgendamento;
        Descricao = descricao;
        Realizado = false;
        // TODO: Inicializar outros atributos no construtor
    }

    #endregion

    #region Métodos

    /// <summary>
    /// Realiza a manutenção utilizando um componente específico.
    /// </summary>
    /// <param name="componente">Componente a ser mantido.</param>
    public void RealizarManutencao(Componente componente)
    {
        componente.RealizarManutencao();
        // TODO: Implementar lógica de realização de manutenção
    }

    #endregion
}
