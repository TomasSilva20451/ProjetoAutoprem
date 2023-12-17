/**
 * @file ConsoleIOService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Definition of the ConsoleIOService class
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class ConsoleIOService : IIOService
{
    #region Métodos

    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadLine()
    {
        return Console.ReadLine() ?? string.Empty;
    }

    public void Clear()
    {
        Console.Clear();
    }

    // Adicione mais métodos conforme necessário

    #endregion
}
