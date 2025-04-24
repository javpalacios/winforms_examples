namespace WinFormsContador;

internal class ContadorPresenter
{
    private ContadorModel model;
    private ContadorView view;

    public ContadorPresenter(ContadorView view, ContadorModel model)
    {
        this.model = model;
        this.view = view;

        view.IncrementarClicked += HandleIncrementar;
        view.DecrementarClicked += HandleDecrementar;
    }

    private void HandleIncrementar(object sender, EventArgs e)
    {
        model.Incrementar();
        view.UpdateDisplay(model.Numero.ToString());
    }

    private void HandleDecrementar(object sender, EventArgs e)
    {
        model.Decrementar();
        view.UpdateDisplay(model.Numero.ToString());
    }
}
