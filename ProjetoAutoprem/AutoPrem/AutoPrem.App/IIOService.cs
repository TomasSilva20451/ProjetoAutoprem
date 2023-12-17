/**
 * @file IIOService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the IIOService interface
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

public interface IIOService
{
    /// <summary>
    /// Escreve uma mensagem na saída.
    /// </summary>
    /// <param name="message">Mensagem a ser escrita.</param>
    void WriteLine(string message);

    /// <summary>
    /// Lê uma linha da entrada.
    /// </summary>
    /// <returns>A linha lida ou uma string vazia se não houver entrada.</returns>
    string ReadLine();

    /// <summary>
    /// Limpa a saída.
    /// </summary>
    void Clear();

    // Adicione mais métodos conforme necessário
}
