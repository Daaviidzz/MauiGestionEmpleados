using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiEmpleados.Models;
using MauiEmpleados.Services;
using System.Collections.ObjectModel;

namespace MauiEmpleados.ViewModels;

public partial class SedesViewModel : ObservableObject
{
    private readonly ApiService _apiService;

    [ObservableProperty]
    private ObservableCollection<Sede> sedes;

    [ObservableProperty]
    private bool cargando;

    public SedesViewModel(ApiService apiService)
    {
        _apiService = apiService;
        Sedes = new ObservableCollection<Sede>();

        GetSedes();
    }

    [RelayCommand]
    public async Task GetSedes()
    {
        Cargando = true;
        try
        {
            var listaDeApi = await _apiService.GetSedesAsync();

            if (listaDeApi != null)
            {
                Sedes.Clear();

                foreach (var sede in listaDeApi)
                {
                    Sedes.Add(sede);
                }
            }
        }
        finally {
            Cargando = false;
        }
       
    }
}
