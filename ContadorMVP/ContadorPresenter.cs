namespace WinFormsContador;

internal class ContadorPresenter
{
    private ContadorModel model;
    private ContadorView view;

    public ContadorPresenter(ContadorView view, ContadorModel model)
    {
        this.model = model;
        this.view = view;

        view.IncrementarClicked += Incrementar;
        view.DecrementarClicked += Decrementar;
    }

    private void Incrementar(object sender, EventArgs e)
    {
        model.Numero++;
        view.NumeroPantalla = model.Numero;
    }

    private void Decrementar(object sender, EventArgs e)
    {
        model.Numero--;
        view.NumeroPantalla = model.Numero;
    }
}
