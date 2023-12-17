// AutoPrem.App/Program.cs
using System;
using AutoPrem.Core;
using AutoPrem.Core.Services;

class Program
{
    static void Main()
    {
        IIOService ioService = new ConsoleIOService();

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
    }
}
