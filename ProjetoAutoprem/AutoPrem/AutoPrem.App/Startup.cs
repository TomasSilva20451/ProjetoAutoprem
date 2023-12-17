// AutoPrem.App/Startup.cs
using Microsoft.Extensions.DependencyInjection;
using AutoPrem.Core;
using AutoPrem.Core.Services; // Certifique-se de que o namespace está correto

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Adicionar serviços necessários
        services.AddScoped<ServicoManutencaoService>();
        // Adicionar outros serviços conforme necessário
    }
}
