/**
 * @file Funcionario.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the Funcionario class
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Funcionario
{
    #region Properties

    public string Nome { get; private set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Funcionario"/> class.
    /// </summary>
    /// <param name="nome">The nome.</param>
    public Funcionario(string nome)
    {
        Nome = nome;
        // TODO: Initialize other attributes in the constructor
    }

    #endregion

    #region Methods

    /// <summary>
    /// Realiza uma tarefa.
    /// </summary>
    /// <returns>True se a tarefa for realizada com sucesso.</returns>
    public bool RealizarTarefa()
    {
        Console.WriteLine($"{Nome} está realizando uma tarefa.");
        // TODO: Implement task logic for Funcionario
        return true;
    }

    // Add more methods and properties as needed

    #endregion
}
