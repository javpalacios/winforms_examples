namespace WinFormsContador;

internal class ContadorView : Form, IContadorView
{
    private Button botonMas;
    private Button botonMenos;
    private Label pantalla;
    private TableLayoutPanel teclado;
    public ContadorView()
    {
        InitializeComponents();
        AttachEventHandlers();
    }

    public int NumeroPantalla { set => pantalla.Text = value.ToString(); }

    public event EventHandler IncrementarClicked;
    public event EventHandler DecrementarClicked;


    private void InitializeComponents()
    {
        botonMas = new Button();
        botonMenos = new Button();
        pantalla = new Label();
        teclado = new TableLayoutPanel();

        teclado.ColumnCount = 2;
        teclado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        teclado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        teclado.Dock = DockStyle.Bottom;
        botonMas.Text = "+";
        botonMas.Dock = DockStyle.Fill;
        botonMenos.Text = "-";
        botonMenos.Dock = DockStyle.Fill;
        pantalla.TextAlign = ContentAlignment.MiddleCenter; 
        pantalla.Text = "0";
        pantalla.Dock = DockStyle.Fill;

        teclado.Controls.Add(botonMas);
        teclado.Controls.Add(botonMenos);
        Controls.Add(pantalla);
        Controls.Add(teclado);
    }

    private void AttachEventHandlers()
    {
        botonMas.Click += (sender, e) => IncrementarClicked?.Invoke(sender, e);
        botonMenos.Click += (sender, e) => DecrementarClicked?.Invoke(sender, e);
    }
}
