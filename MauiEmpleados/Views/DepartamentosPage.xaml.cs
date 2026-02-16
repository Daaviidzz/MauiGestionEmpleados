using MauiEmpleados.ViewModels;

namespace MauiEmpleados.Views;

public partial class DepartamentosPage : ContentPage
{
	public DepartamentosPage(DepartamentosViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}