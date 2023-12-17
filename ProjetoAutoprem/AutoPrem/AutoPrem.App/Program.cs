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

        // Lidando com exceções ao ligar os veículos
        try
        {
            veiculo.Ligar();
            ioService.WriteLine($"Veículo {veiculo.ID} ligado com sucesso.");
        }
        catch (Exception ex)
        {
            ioService.WriteLine($"Erro ao ligar veículo {veiculo.ID}: {ex.Message}");
        }

        try
        {
            carro.Ligar();
            ioService.WriteLine($"Carro {carro.ID} ligado com sucesso.");
        }
        catch (Exception ex)
        {
            ioService.WriteLine($"Erro ao ligar carro {carro.ID}: {ex.Message}");
        }

        try
        {
            moto.Ligar();
            ioService.WriteLine($"Moto {moto.ID} ligada com sucesso.");
        }
        catch (Exception ex)
        {
            ioService.WriteLine($"Erro ao ligar moto {moto.ID}: {ex.Message}");
        }

        // Lidando com exceções ao desligar os veículos
        try
        {
            veiculo.Desligar();
            ioService.WriteLine($"Veículo {veiculo.ID} desligado com sucesso.");
        }
        catch (Exception ex)
        {
            ioService.WriteLine($"Erro ao desligar veículo {veiculo.ID}: {ex.Message}");
        }

        try
        {
            carro.Desligar();
            ioService.WriteLine($"Carro {carro.ID} desligado com sucesso.");
        }
        catch (Exception ex)
        {
            ioService.WriteLine($"Erro ao desligar carro {carro.ID}: {ex.Message}");
        }

        try
        {
            moto.Desligar();
            ioService.WriteLine($"Moto {moto.ID} desligada com sucesso.");
        }
        catch (Exception ex)
        {
            ioService.WriteLine($"Erro ao desligar moto {moto.ID}: {ex.Message}");
        }
        #endregion

        #region Serviços e Tarefas
        // Exemplo de utilização de serviços e tarefas
        // Serviço de Manutenção
        try
        {
            ServicoManutencao servico = new ServicoManutencao(DateTime.Now, "Manutenção de rotina");
            servico.RealizarManutencao(new ComponenteEspecifico());
            ioService.WriteLine("Manutenção realizada com sucesso.");
        }
        catch (Exception ex)
        {
            ioService.WriteLine($"Erro ao realizar manutenção: {ex.Message}");
        }

        // Tarefa do Funcionário
        try
        {
            bool sucessoTarefa = funcionario.RealizarTarefa(new ComponenteEspecifico());
            ioService.WriteLine(sucessoTarefa ? "Tarefa realizada com sucesso." : "Erro ao realizar tarefa.");
        }
        catch (Exception ex)
        {
            ioService.WriteLine($"Erro ao realizar tarefa: {ex.Message}");
        }
        #endregion

        // Adicione mais funcionalidades conforme necessário
    }
}
