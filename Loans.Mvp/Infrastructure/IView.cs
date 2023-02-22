namespace Loans.Mvp.Infrastructure;

public interface IView
{
    IViewResult ShowView();
    void CloseView();
    void InvokeOnUIThread(Action action);
    void SetErrors(IDictionary<string, string> errors);
}
