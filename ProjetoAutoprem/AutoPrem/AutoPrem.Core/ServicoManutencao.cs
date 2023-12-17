// AutoPrem.Core/ServicoManutencao.cs
using System;

public class ServicoManutencao
{
    #region Propriedades

    public DateTime DataAgendamento { get; }
    public string Descricao { get; private set; }
    public bool Realizado { get; set; } // Alterado de private set para set

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

    public void RealizarManutencao(Componente componente)
    {
        componente.RealizarManutencao();
        // TODO: Implementar lógica de realização de manutenção
    }

    #endregion
}
