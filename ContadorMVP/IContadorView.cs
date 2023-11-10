namespace WinFormsContador;

internal interface IContadorView
{
    public event EventHandler IncrementarClicked;
    public event EventHandler DecrementarClicked;

    public int NumeroPantalla { set; }
}