using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiEmpleados.Models;
using MauiEmpleados.Services;
using MauiEmpleados.Views;
using System.Collections.ObjectModel;

namespace MauiEmpleados.ViewModels;

public partial class DepartamentosViewModel : ObservableObject
{
    private readonly ApiService _apiService;

    [ObservableProperty]
    private ObservableCollection<Departamento> departamentos;

    [ObservableProperty]
    private bool cargando;


    public DepartamentosViewModel(ApiService apiService)
    {
        _apiService = apiService;
        Departamentos = new ObservableCollection<Departamento>();

        GetDepartamentos();
    }
    [RelayCommand]
    public async Task IrAEstadisticas()
    {
        var parametros = new Dictionary<string, object>
    {
        { "Datos", Departamentos.ToList() }
    };

        await Shell.Current.GoToAsync("EstadisticasPage", parametros);
    }

    [RelayCommand]  
    public async Task GetDepartamentos()
    {
        Cargando = true;
        //delay para comprobar que funcione
        await Task.Delay(2000);
        try
        {
            var listaDeApi = await _apiService.GetDepartamentosAsync();

            if (listaDeApi != null)
            {
                Departamentos.Clear();

                foreach (var dep in listaDeApi)
                {
                    Departamentos.Add(dep);
                }
            }
        }
        finally
        {
            Cargando = false;
        }
       
    }
}
