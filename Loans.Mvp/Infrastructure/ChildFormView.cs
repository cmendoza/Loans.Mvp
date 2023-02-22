namespace Loans.Mvp.Infrastructure;

public class ChildFormView : BaseFormView, IChildView
{
    public IView? ParentView
    {
        get => MdiParent as IView;
        set => MdiParent = value as Form;
    }
}
