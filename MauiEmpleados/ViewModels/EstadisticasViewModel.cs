using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using MauiEmpleados.Models;
using MauiEmpleados.Services;
using System.Collections.ObjectModel;

namespace MauiEmpleados.ViewModels;

public partial class EstadisticasViewModel : ObservableObject
{
    private readonly ApiService _apiService;

    [ObservableProperty]
    private ObservableCollection<ISeries> series;

    [ObservableProperty]
    private bool estaCargando;

    public EstadisticasViewModel(ApiService apiService)
    {
        _apiService = apiService;
        Series = new ObservableCollection<ISeries>();
    }

    [RelayCommand]
    public async Task RecargarDatos()
    {
        EstaCargando = true;

        var datos = await _apiService.GetDepartamentosAsync();

        if (datos != null && datos.Count > 0)
        {
            CargarGrafica(datos);
        }

        EstaCargando = false;
    }

    public void CargarGrafica(List<Departamento> listaDeptos)
    {
        var nuevasSeries = new ObservableCollection<ISeries>();

        foreach (var depto in listaDeptos)
        {
            nuevasSeries.Add(new PieSeries<float>
            {
                Values = new float[] { depto.Ganancias ?? 0 },
                Name = depto.Nombre,
                DataLabelsPaint = new LiveChartsCore.SkiaSharpView.Painting.SolidColorPaint(SkiaSharp.SKColors.Black),
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer
            });
        }

        Series = nuevasSeries;
    }
}