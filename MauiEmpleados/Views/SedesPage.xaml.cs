using MauiEmpleados.ViewModels;

namespace MauiEmpleados.Views;

public partial class SedesPage : ContentPage
{
	public SedesPage(SedesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}