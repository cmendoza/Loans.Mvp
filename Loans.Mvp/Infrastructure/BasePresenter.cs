namespace Loans.Mvp.Infrastructure;

public abstract class BasePresenter<TView> where TView : IView
{
    protected BasePresenter(TView view) => View = view;

    public TView View { get; }

    public virtual IViewResult ShowView() => View.ShowView();
}
