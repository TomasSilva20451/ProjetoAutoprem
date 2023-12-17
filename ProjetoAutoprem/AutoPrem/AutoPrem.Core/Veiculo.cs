/**
 * @file Veiculo.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the Veiculo class
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Veiculo
{
    #region Atributos

    public int ID { get; }
    public bool EstaEmManutencao { get; protected set; }

    #endregion

    #region Construtores

    /// <summary>
    /// Construtor da classe Veiculo.
    /// </summary>
    /// <param name="id">Identificador único do veículo.</param>
    public Veiculo(int id)
    {
        ID = id;
        EstaEmManutencao = false;
        // TODO: Inicializar outros atributos no construtor, se necessário
    }

    #endregion

    #region Métodos

    /// <summary>
    /// Realiza a manutenção do veículo, se não estiver em manutenção.
    /// </summary>
    /// <returns>True se a manutenção foi realizada com sucesso; False se o veículo já está em manutenção.</returns>
    public bool RealizarManutencao()
    {
        if (!EstaEmManutencao)
        {
            Console.WriteLine($"Realizando manutenção do veículo {ID}.");
            // TODO: Implementar lógica de manutenção
            EstaEmManutencao = true;
            return true;
        }
        else
        {
            Console.WriteLine($"O veículo {ID} já está em manutenção.");
            return false;
        }
    }

    /// <summary>
    /// Liga o veículo.
    /// </summary>
    public virtual void Ligar()
    {
        Console.WriteLine($"O veículo {ID} está ligado.");
    }

    /// <summary>
    /// Desliga o veículo.
    /// </summary>
    public virtual void Desligar()
    {
        Console.WriteLine($"O veículo {ID} está desligado.");
    }

    #endregion

    #region Outros Métodos

    // Adicione mais métodos e propriedades conforme necessário

    #endregion
}
