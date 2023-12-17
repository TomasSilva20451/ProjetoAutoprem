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

class Program
{
    static void Main()
    {
        IIOService ioService = new ConsoleIOService();

        // Utilize ioService.WriteLine e ioService.ReadLine em vez de Console.WriteLine e Console.ReadLine

        // Exemplo de utilização das classes e serviços implementados
        Veiculo veiculo = new Carro(1);
        Carro carro = new Carro(2);
        Moto moto = new Moto(3);
        Funcionario funcionario = new Funcionario("João");

        veiculo.Ligar();
        carro.Ligar();
        moto.Ligar();

        ioService.Clear();

        veiculo.Desligar();
        carro.Desligar();
        moto.Desligar();

        ioService.Clear();

        ServicoManutencao servico = new ServicoManutencao(DateTime.Now, "Manutenção de rotina");
        servico.RealizarManutencao(new ComponenteEspecifico());

        funcionario.RealizarTarefa(new ComponenteEspecifico());

        // Adicione mais funcionalidades conforme necessário

        // Note: Since there are no explicit instructions on what to include in the Main method,
        // you may add the necessary code based on your application requirements.
    }
}