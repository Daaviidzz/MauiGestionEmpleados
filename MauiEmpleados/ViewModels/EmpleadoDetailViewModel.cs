using CommunityToolkit.Mvvm.ComponentModel;
using MauiEmpleados.Models;

namespace MauiEmpleados.ViewModels;


/* * El atributo [QueryProperty] es el "receptor" de datos.
 * Funciona así: [QueryProperty(PropiedadDondeSeGuarda, "NombreDelParametroEnviado")]
 * Cuando navegamos y enviamos un "Empleado", MAUI lo busca aquí y lo asigna automáticamente.
 */

[QueryProperty(nameof(Empleado), "Empleado")]
public partial class EmpleadoDetailViewModel : ObservableObject
{
    // Esta es la propiedad que recibirá los datos del empleado seleccionado.
    // Gracias al [ObservableProperty], la vista (XAML) se actualizará sola cuando llegue el dato.
    [ObservableProperty]
    private Empleado empleado;
}
