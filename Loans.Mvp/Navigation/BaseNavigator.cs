using Loans.Mvp.Infrastructure;

namespace Loans.Mvp.Navigation;

internal abstract class BaseNavigator
{
    public object? DataContext { get; set; }

    public abstract void ShowChild<TPresenter, TView>(IView parent)
        where TPresenter : BasePresenter<TView>
        where TView : IChildView;

    public abstract TResult ShowModal<TPresenter, TView, TResult>()
        where TPresenter : BasePresenter<TView>
        where TView : IView;
}