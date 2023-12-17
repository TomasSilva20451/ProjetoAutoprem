/**
 * @file Startup.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Configuration of services for the application
 * @version 0.2
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using Microsoft.Extensions.DependencyInjection;
using AutoPrem.Core;
using AutoPrem.Core.Services; // Certifique-se de que o namespace está correto

public class Startup
{
    #region Configuração de Serviços
    public void ConfigureServices(IServiceCollection services)
    {
        // Adicionar serviços necessários
        services.AddScoped<ServicoManutencaoService>();
        // Adicionar outros serviços conforme necessário
    }
    #endregion
}
