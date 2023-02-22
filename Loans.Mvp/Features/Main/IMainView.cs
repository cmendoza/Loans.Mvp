using Loans.Mvp.Infrastructure;

namespace Loans.Mvp.Features.Main;

internal interface IMainView : IView
{
    public bool AskBeforeClosing { get; set; }

    event EventHandler? ViewShown;
}
