using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiEmpleados.Models;
using MauiEmpleados.Services;
using System.Collections.ObjectModel;

namespace MauiEmpleados.ViewModels;

[QueryProperty(nameof(DepartamentoId), "DepartamentoId")]
public partial class EmpleadosViewModel : ObservableObject
{
    private readonly ApiService _apiService;

    [ObservableProperty]
    private ObservableCollection<Empleado> empleados;

    [ObservableProperty]
    private bool cargando;


    [ObservableProperty]
    private int? departamentoId;

    public EmpleadosViewModel(ApiService apiService)
    {
        _apiService = apiService;
        Empleados = new ObservableCollection<Empleado>();

        GetEmpleados();
    }

    partial void OnDepartamentoIdChanged(int? value)
    {
        if (value.HasValue)
        {
            FiltrarEmpleadosPorDepartamento(value.Value);
        }
    }


    private void FiltrarEmpleadosPorDepartamento(int id)
    {

        var filtrados = Empleados.Where(e => e.DepartamentoId == id).ToList();

        Empleados.Clear();
        foreach (var emp in filtrados)
        {
            Empleados.Add(emp);
        }
    }

    [RelayCommand]
    public async Task GetEmpleados()
    {
        Cargando = true;
        try
        {
            var listaDeApi = await _apiService.GetEmpleadosAsync();

            if (listaDeApi != null)
            {
                Empleados.Clear();

                foreach (var emp in listaDeApi)
                {
                    Empleados.Add(emp);
                }
            }
        }
        finally
        {
            Cargando = false;
        }
        
    }

    [RelayCommand]
    public async Task IrADetalles(Empleado empleadoSeleccionado)
    {
        if (empleadoSeleccionado == null) return;

        var parametros = new Dictionary<string, object>
    {
        { "Empleado", empleadoSeleccionado }
    };

        // Navegamos a la página de detalles pasando los parámetros
        await Shell.Current.GoToAsync(nameof(Views.EmpleadoDetailPage), parametros);
    }

    [RelayCommand]
    public async Task IrAEmpleadosPorDepartamento(Departamento deptoSeleccionado)
    {
        if (deptoSeleccionado == null) return;

        await Shell.Current.GoToAsync($"///{nameof(Views.EmpleadosPage)}", new Dictionary<string, object>
        {
            { "DepartamentoId", deptoSeleccionado.Id }
        });
    }

}