using MauiEmpleados.Models;
using MauiEmpleados.ViewModels;
using System.Collections.Generic;

namespace MauiEmpleados.Views;

[QueryProperty(nameof(DatosRecibidos), "Datos")]
public partial class EstadisticasPage : ContentPage, IQueryAttributable
{
    private readonly EstadisticasViewModel _viewModel;

    public EstadisticasPage(EstadisticasViewModel viewModel)
    {
        InitializeComponent();

        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    public List<Departamento> DatosRecibidos
    {
        set
        {
            if (value != null)
            {
                _viewModel.CargarGrafica(value);
            }
        }
    }


    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query == null) return;

        if (query.TryGetValue("Datos", out var datosObj))
        {
            if (datosObj is List<Departamento> lista)
            {
                _viewModel.CargarGrafica(lista);
            }
            else if (datosObj is IEnumerable<Departamento> enumList)
            {
                _viewModel.CargarGrafica(enumList.ToList());
            }
        }
    }
}