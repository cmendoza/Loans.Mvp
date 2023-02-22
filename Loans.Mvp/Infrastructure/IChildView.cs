namespace Loans.Mvp.Infrastructure;

public interface IChildView : IView
{
    IView? ParentView { get; set; }
}
