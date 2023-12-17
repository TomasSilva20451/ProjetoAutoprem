/**
 * @file Carro.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the Carro class, derived from Veiculo
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Carro : Veiculo
{
    #region Construtores

    public Carro(int id) : base(id)
    {
        // TODO: Inicializar atributos específicos de Carro no construtor
    }

    #endregion

    #region Métodos

    public override void Ligar()
    {
        base.Ligar();
        Console.WriteLine($"O carro {ID} está ligado.");
    }

    public override void Desligar()
    {
        base.Desligar();
        Console.WriteLine($"O carro {ID} está desligado.");
    }

    public bool RealizarManutencaoCarro()
    {
        if (!EstaEmManutencao)
        {
            Console.WriteLine($"Realizando manutenção do carro {ID}.");
            // TODO: Implementar lógica de manutenção específica de Carro
            EstaEmManutencao = true;
            return true;
        }
        else
        {
            Console.WriteLine($"O carro {ID} já está em manutenção.");
            return false;
        }
    }

    #endregion

    #region Outros Métodos

    // Adicione mais métodos e propriedades conforme necessário

    #endregion
}
