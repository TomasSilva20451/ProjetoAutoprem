/**
 * @file Program.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Main entry point for the application
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections.Generic;

class Program
{
    #region Main Method

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    static void Main()
    {
        // Create an instance of the ConsoleIOService for input and output
        IIOService ioService = new ConsoleIOService();

        // Example: Creating and using instances of Veiculo, Carro, and Moto
        Veiculo veiculo = new Veiculo(1);
        Carro carro = new Carro(2);
        Moto moto = new Moto(3);

        List<Veiculo> veiculos = new List<Veiculo> { veiculo, carro, moto };

        foreach (var v in veiculos)
        {
            // Example: Calling the RealizarManutencao method using polymorphism
            bool manutencaoResult = v.RealizarManutencao();
            ioService.WriteLine($"Manutencao realizada com sucesso: {manutencaoResult}");
        }

        // TODO: Add more code based on your application requirements

        // Restante do código (remaining code)...

        // Note: Since there are no explicit instructions on what to include in the Main method,
        // you may add the necessary code based on your application requirements.
    }

    #endregion
}
