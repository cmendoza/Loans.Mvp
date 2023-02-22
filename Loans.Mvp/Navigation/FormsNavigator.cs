using Microsoft.Extensions.DependencyInjection;
using Loans.Mvp.Infrastructure;

namespace Loans.Mvp.Navigation;

internal sealed class FormsNavigator : BaseNavigator
{
    private readonly IServiceProvider _serviceProvider;

    public FormsNavigator(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

    public override void ShowChild<TPresenter, TView>(IView parent)
    {
        var presenter = _serviceProvider.GetRequiredService<TPresenter>();
        presenter.View.ParentView = parent;
        presenter.ShowView();
    }

    public override TResult ShowModal<TPresenter, TView, TResult>()
    {
        var presenter = _serviceProvider.GetRequiredService<TPresenter>();
        return presenter.ShowView() is ViewResult<TResult> viewResult
            ? viewResult.Result
            : throw new InvalidOperationException();
    }
}
