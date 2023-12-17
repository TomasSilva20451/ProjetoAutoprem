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
    void WriteLine(string message);
    string ReadLine();
    void Clear();
    // Adicione mais métodos conforme necessário
}
