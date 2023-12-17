/**
 * @file Program.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Main entry point for the application
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;
using AutoPrem.Core;
using AutoPrem.Core.Services;

class Program
{
    static void Main()
    {
        #region Configuração de Entrada/Saída
        IIOService ioService = new ConsoleIOService();
        #endregion

        #region Exemplo de Utilização
        // Exemplo de utilização das classes e serviços implementados
        Veiculo veiculo = new Carro(1);
        Carro carro = new Carro(2);
        Moto moto = new Moto(3);
        Funcionario funcionario = new Funcionario("João");

        // Iniciando exemplos de utilização:

        // Ligando os veículos:
        veiculo.Ligar();
        carro.Ligar();
        moto.Ligar();

        // Desligando os veículos:
        veiculo.Desligar();
        carro.Desligar();
        moto.Desligar();
        #endregion

        #region Serviços e Tarefas
        // Exemplo de utilização de serviços e tarefas
        // Exemplo de Serviço de Manutenção:
        ServicoManutencao servico = new ServicoManutencao(DateTime.Now, "Manutenção de rotina");
        servico.RealizarManutencao(new ComponenteEspecifico());

        // Exemplo de Tarefa do Funcionário:
        funcionario.RealizarTarefa(new ComponenteEspecifico());
        #endregion

        
    }
}
