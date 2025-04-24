namespace WinFormsContador;

internal class ContadorModel
{
    public int Numero { get; set; } = 0;

    public void Incrementar() => Numero++;
    public void Decrementar() => Numero--;
}
