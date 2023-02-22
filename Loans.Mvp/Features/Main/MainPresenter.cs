using Loans.Mvp.Features.Login;
using Loans.Mvp.Infrastructure;
using Loans.Mvp.Navigation;

namespace Loans.Mvp.Features.Main;

internal sealed class MainPresenter : BasePresenter<IMainView>
{
    public MainPresenter(IMainView view) : base(view)
    {
        view.ViewShown += View_ViewShown;
    }

    private void View_ViewShown(object? sender, EventArgs e)
    {
        var success = NavigationService.Navigator.ShowModal<LoginPresenter, ILoginView, bool>();
        if (!success)
        {
            View.CloseView();
        }
    }
}
