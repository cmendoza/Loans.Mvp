using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Loans.Mvp.Features.Login;
using Loans.Mvp.Features.Main;
using Loans.Mvp.Navigation;
using Loans.Mvp.Utils;

namespace Loans.Mvp;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();

        NavigationService.Navigator = host.Services.GetRequiredService<BaseNavigator>();
        var presenter = host.Services.GetRequiredService<MainPresenter>();

        Application.Run(presenter.View as Form);
    }

    static IHostBuilder CreateHostBuilder()
        => Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services
                    .AddPresenterWithView<MainPresenter, IMainView, Main>()
                    .AddPresenterWithView<LoginPresenter, ILoginView, Login>()
                    .AddTransient<BaseNavigator, FormsNavigator>();
            });
}