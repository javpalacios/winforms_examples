namespace WinFormsContador
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ContadorModel model = new();
            ContadorView view = new();
            new ContadorPresenter(view, model);

            Application.Run(view);
        }
    }
}