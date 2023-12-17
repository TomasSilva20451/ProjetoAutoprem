﻿/**
 * @file Moto.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the Moto class, derived from Veiculo
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Moto : Veiculo
{
    #region Construtores

    /// <summary>
    /// Construtor da classe Moto.
    /// </summary>
    /// <param name="id">Identificador da moto.</param>
    public Moto(int id) : base(id)
    {
        // TODO: Inicializar atributos específicos de Moto no construtor
    }

    #endregion

    #region Métodos

    /// <summary>
    /// Liga a moto.
    /// </summary>
    public override void Ligar()
    {
        base.Ligar();
        Console.WriteLine($"A moto {ID} está ligada.");
    }

    /// <summary>
    /// Desliga a moto.
    /// </summary>
    public override void Desligar()
    {
        base.Desligar();
        Console.WriteLine($"A moto {ID} está desligada.");
    }

    /// <summary>
    /// Realiza a manutenção da moto.
    /// </summary>
    /// <returns>True se a manutenção foi realizada com sucesso; false, caso contrário.</returns>
    public bool RealizarManutencaoMoto()
    {
        if (!EstaEmManutencao)
        {
            Console.WriteLine($"Realizando manutenção da moto {ID}.");
            // TODO: Implementar lógica de manutenção específica de Moto
            EstaEmManutencao = true;
            return true;
        }
        else
        {
            Console.WriteLine($"A moto {ID} já está em manutenção.");
            return false;
        }
    }

    #endregion

    #region Outros Métodos

    // Adicione mais métodos e propriedades conforme necessário

    #endregion
}
