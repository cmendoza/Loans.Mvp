using Loans.Mvp.Infrastructure;

namespace Loans.Mvp.Features.Login;

internal class LoginPresenter : BasePresenter<ILoginView>
{
    public LoginPresenter(ILoginView view) : base(view)
    {
        view.LoginClicked += View_LoginClicked;
    }

    private void View_LoginClicked(object? sender, EventArgs e)
    {
        if (View.UserName == "sist" && View.Password == "admin")
        {
            View.CloseView(true);
            return;
        }

        MessageBox.Show("Fail!");
    }
}
