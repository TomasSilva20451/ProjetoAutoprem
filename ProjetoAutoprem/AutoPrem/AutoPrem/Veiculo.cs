/**
 * @file Veiculo.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the Veiculo class
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Veiculo
{
    #region Attributes

    public int ID { get; }
    public bool EstaEmManutencao { get; protected set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Veiculo"/> class.
    /// </summary>
    /// <param name="id">The identifier.</param>
    public Veiculo(int id)
    {
        ID = id;
        EstaEmManutencao = false;
        // TODO: Initialize other attributes in the constructor
    }

    #endregion

    #region Methods

    /// <summary>
    /// Realiza a manutenção do veículo.
    /// </summary>
    /// <returns>True se a manutenção for realizada com sucesso; False se o veículo já estiver em manutenção.</returns>
    public bool RealizarManutencao()
    {
        if (!EstaEmManutencao)
        {
            Console.WriteLine($"Realizando manutenção do veículo {ID}.");
            // TODO: Implement maintenance logic
            EstaEmManutencao = true;
            return true;
        }
        else
        {
            Console.WriteLine($"O veículo {ID} já está em manutenção.");
            return false;
        }
    }

    // Add more methods and properties as needed

    #endregion
}
