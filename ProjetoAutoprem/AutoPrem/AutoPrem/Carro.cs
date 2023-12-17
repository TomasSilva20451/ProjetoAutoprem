/**
 * @file Carro.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the Carro class, derived from Veiculo
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Carro : Veiculo
{
    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Carro"/> class.
    /// </summary>
    /// <param name="id">The identifier.</param>
    public Carro(int id) : base(id)
    {
        // TODO: Initialize Carro-specific attributes in the constructor
    }

    #endregion

    #region Methods

    /// <summary>
    /// Realiza a manutenção específica de um carro.
    /// </summary>
    /// <returns>True se a manutenção for realizada com sucesso; False se o carro já estiver em manutenção.</returns>
    public bool RealizarManutencaoCarro()
    {
        if (!EstaEmManutencao)
        {
            Console.WriteLine($"Realizando manutenção do carro {ID}.");
            // TODO: Implement Carro-specific maintenance logic
            EstaEmManutencao = true;
            return true;
        }
        else
        {
            Console.WriteLine($"O carro {ID} já está em manutenção.");
            return false;
        }
    }

    // Add more methods and properties as needed

    #endregion
}
