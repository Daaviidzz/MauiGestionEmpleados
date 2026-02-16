namespace MauiEmpleados
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Views.EmpleadoDetailPage), typeof(Views.EmpleadoDetailPage));
            Routing.RegisterRoute(nameof(Views.EstadisticasPage), typeof(Views.EstadisticasPage));
        }
    }
}
