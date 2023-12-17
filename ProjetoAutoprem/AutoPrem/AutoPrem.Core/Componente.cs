/**
 * @file Componente.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the abstract Componente class
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

public abstract class Componente
{
    #region Métodos Abstratos

    /// <summary>
    /// Realiza a manutenção do componente.
    /// </summary>
    public abstract void RealizarManutencao();

    /// <summary>
    /// Substitui o componente por um novo.
    /// </summary>
    public abstract void Substituir();

    #endregion

    #region Outros Métodos e Propriedades

    // Adicione mais métodos e propriedades conforme necessário

    #endregion
}
