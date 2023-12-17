/**
 * @file Funcionario.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the Funcionario class
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Funcionario
{
    #region Propriedades

    public string Nome { get; private set; }

    #endregion

    #region Construtores

    /// <summary>
    /// Construtor da classe Funcionario.
    /// </summary>
    /// <param name="nome">Nome do funcionário.</param>
    public Funcionario(string nome)
    {
        Nome = nome;
        // TODO: Inicializar outros atributos no construtor
    }

    #endregion

    #region Métodos

    /// <summary>
    /// Realiza uma tarefa utilizando o componente.
    /// </summary>
    /// <param name="componente">Componente a ser utilizado na tarefa.</param>
    /// <returns>True se a tarefa foi realizada com sucesso; false, caso contrário.</returns>
    public bool RealizarTarefa(Componente componente)
    {
        Console.WriteLine($"{Nome} está realizando uma tarefa.");
        componente.RealizarManutencao();
        // TODO: Implementar lógica de tarefa usando o componente
        return true;
    }

    // Adicione mais métodos e propriedades conforme necessário

    #endregion
}
