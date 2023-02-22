using Loans.Mvp.Infrastructure;

namespace Loans.Mvp.Features.Main;

public partial class Main : BaseFormView, IMainView
{
    public Main() => InitializeComponent();

    public bool AskBeforeClosing { get; set; }

    public event EventHandler? ViewShown
    {
        add => Shown += value;
        remove => Shown -= value;
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!AskBeforeClosing) return;

        var result = MessageBox.Show(
            "¿Realmente desea salir?",
            "Confirme",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

        if (result == DialogResult.Yes) return;

        e.Cancel = true;
    }
}
