using GimnasioClientes;

namespace Registro_de_Clientes_del_Gimnasio
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);  // Mejor manejo de DPI
            Application.Run(new frmClientes());
        }
}
  }