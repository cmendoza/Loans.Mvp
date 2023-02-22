using Microsoft.Extensions.DependencyInjection;
using Loans.Mvp.Infrastructure;

namespace Loans.Mvp.Utils;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresenterWithView<TPresenter, TViewInterface, TView>(
        this IServiceCollection services)
        where TPresenter : BasePresenter<TViewInterface>
        where TViewInterface : class, IView
        where TView : class, TViewInterface
    {
        services.AddSingleton<TViewInterface, TView>();
        services.AddSingleton<TPresenter>();
        return services;
    }
}
