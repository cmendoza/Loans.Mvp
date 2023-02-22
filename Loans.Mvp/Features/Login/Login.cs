using Loans.Mvp.Infrastructure;

namespace Loans.Mvp.Features.Login;

public partial class Login : BaseFormView, ILoginView
{
    private bool _result;

    public Login() => InitializeComponent();

    public string UserName => userNameText.Text;

    public string Password => passwordText.Text;

    public event EventHandler? LoginClicked;

    public void CloseView(bool result)
    {
        _result = result;
        Close();
    }

    public override ViewResult<bool> ShowView()
    {
        ShowDialog();
        return _result;
    }

    private void LoginButton_Click(object sender, EventArgs e)
        => LoginClicked?.Invoke(this, EventArgs.Empty);

    private void CloseButton_Click(object sender, EventArgs e) => Close();
}
