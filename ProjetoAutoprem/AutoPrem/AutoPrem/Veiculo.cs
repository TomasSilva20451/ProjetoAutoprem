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

    public Veiculo(int id)
    {
        ID = id;
        EstaEmManutencao = false;
        // TODO: Inicializar outros atributos no construtor
    }

    #endregion

    #region Métodos

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

    public virtual void Ligar()
    {
        Console.WriteLine($"O veículo {ID} está ligado.");
    }

    public virtual void Desligar()
    {
        Console.WriteLine($"O veículo {ID} está desligado.");
    }

    #endregion

    #region Outros Métodos

    // Adicione mais métodos e propriedades conforme necessário

    #endregion
}
