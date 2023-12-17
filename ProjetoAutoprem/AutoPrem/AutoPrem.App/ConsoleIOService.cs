/**
 * @file ConsoleIOService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the ConsoleIOService class
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class ConsoleIOService : IIOService
{
    #region Atributos

    // Adicione atributos, se necessário

    #endregion

    #region Construtores

    // Adicione construtores, se necessário

    #endregion

    #region Métodos

    /// <summary>
    /// Escreve uma mensagem na console.
    /// </summary>
    /// <param name="message">Mensagem a ser escrita.</param>
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    /// <summary>
    /// Lê uma linha da console.
    /// </summary>
    /// <returns>A linha lida ou uma string vazia se não houver entrada.</returns>
    public string ReadLine()
    {
        return Console.ReadLine() ?? string.Empty;
    }

    /// <summary>
    /// Limpa a console.
    /// </summary>
    public void Clear()
    {
        Console.Clear();
    }

    // Adicione mais métodos conforme necessário

    #endregion

    #region Overrides

    // Adicione métodos overrides, se necessário

    #endregion

    #region Outros Métodos

    // Adicione outros métodos, se necessário

    #endregion

    #region Destrutores

    // Adicione destrutores, se necessário

    #endregion
}
