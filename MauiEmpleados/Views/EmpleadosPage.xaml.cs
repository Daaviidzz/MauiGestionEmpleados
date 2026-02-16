using MauiEmpleados.ViewModels;

namespace MauiEmpleados.Views;

public partial class EmpleadosPage : ContentPage
{
    public EmpleadosPage(EmpleadosViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

}