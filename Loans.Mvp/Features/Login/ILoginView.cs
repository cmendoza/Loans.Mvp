using Loans.Mvp.Infrastructure;

namespace Loans.Mvp.Features.Login;

public interface ILoginView : IView
{
    string UserName { get; }
    string Password { get; }

    event EventHandler? LoginClicked;

    void CloseView(bool result);
}
