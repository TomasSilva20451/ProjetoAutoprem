/**
 * @file IIOService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the IIOService interface
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

public interface IIOService
{
    /// <summary>
    /// Writes a message to the output.
    /// </summary>
    /// <param name="message">The message to write.</param>
    void WriteLine(string message);

    /// <summary>
    /// Reads a line of input.
    /// </summary>
    /// <returns>The input line.</returns>
    string ReadLine();
}
