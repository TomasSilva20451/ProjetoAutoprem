/**
 * @file ConsoleIOService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Implementation of the IIOService interface using Console methods
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class ConsoleIOService : IIOService
{
    /// <inheritdoc />
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    /// <inheritdoc />
    public string ReadLine()
    {
        return Console.ReadLine() ?? string.Empty;
    }
}
