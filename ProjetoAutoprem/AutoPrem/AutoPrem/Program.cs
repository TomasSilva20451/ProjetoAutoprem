﻿// AutoPrem.App/Program.cs

class Program
{
    static void Main()
    {
        // Ponto de entrada para o projeto AutoPrem

        // Exemplo de utilização das classes e serviços implementados
        Veiculo veiculo = new Carro(1);
        Carro carro = new Carro(2);
        Moto moto = new Moto(3);
        Funcionario funcionario = new Funcionario("João");

        veiculo.Ligar();
        carro.Ligar();
        moto.Ligar();

        System.Console.Clear();

        veiculo.Desligar();
        carro.Desligar();
        moto.Desligar();

        System.Console.Clear();

        ServicoManutencaoService servicoManutencaoService = new ServicoManutencaoService();

        ServicoManutencao servico = new ServicoManutencao(System.DateTime.Now, "Manutenção de rotina");
        servicoManutencaoService.RealizarManutencao(servico, new ComponenteEspecifico());

        funcionario.RealizarTarefa(new ComponenteEspecifico());

        // Adicione mais funcionalidades conforme necessário
    }
}
