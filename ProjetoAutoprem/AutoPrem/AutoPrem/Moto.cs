/**
 * @file Moto.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the Moto class, derived from Veiculo
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Moto : Veiculo
{
    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Moto"/> class.
    /// </summary>
    /// <param name="id">The identifier.</param>
    public Moto(int id) : base(id)
    {
        // TODO: Initialize Moto-specific attributes in the constructor
    }

    #endregion

    #region Methods

    /// <summary>
    /// Realiza a manutenção específica de uma moto.
    /// </summary>
    /// <returns>True se a manutenção for realizada com sucesso; False se a moto já estiver em manutenção.</returns>
    public bool RealizarManutencaoMoto()
    {
        if (!EstaEmManutencao)
        {
            Console.WriteLine($"Realizando manutenção da moto {ID}.");
            // TODO: Implement Moto-specific maintenance logic
            EstaEmManutencao = true;
            return true;
        }
        else
        {
            Console.WriteLine($"A moto {ID} já está em manutenção.");
            return false;
        }
    }

    // Add more methods and properties as needed

    #endregion
}
