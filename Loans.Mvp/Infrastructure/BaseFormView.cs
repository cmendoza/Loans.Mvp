namespace Loans.Mvp.Infrastructure;

public class BaseFormView : Form, IView
{
    public void InvokeOnUIThread(Action action) => Invoke(action);

    public virtual void SetErrors(IDictionary<string, string> errors) { }

    public virtual IViewResult ShowView()
    {
        Show();
        return ViewResult.Empty;
    }

    public virtual void CloseView() => Close();
}
