namespace WinFormsContador;

internal interface IContadorView
{
    public event EventHandler IncrementarClicked;
    public event EventHandler DecrementarClicked;

    public void UpdateDisplay(string data);
}