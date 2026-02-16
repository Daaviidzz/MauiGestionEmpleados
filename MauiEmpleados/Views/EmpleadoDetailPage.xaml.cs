using MauiEmpleados.ViewModels;

namespace MauiEmpleados.Views;

public partial class EmpleadoDetailPage : ContentPage
{
	public EmpleadoDetailPage(EmpleadoDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}