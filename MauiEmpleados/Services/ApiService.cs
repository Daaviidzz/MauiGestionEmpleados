using CommunityToolkit.Mvvm.ComponentModel;
using MauiEmpleados.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace MauiEmpleados.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    private const string BaseUrl = "http://localhost:8080";

 
    public ApiService()
    {
        _httpClient = new HttpClient() { BaseAddress = new Uri(BaseUrl) };
    }

    public async Task<List<Departamento>> GetDepartamentosAsync()
    {
        try
        {
            var departamentos = await _httpClient.GetFromJsonAsync<List<Departamento>>("departamentos/");
            return departamentos ?? new List<Departamento>();
        }
        catch (Exception ex)
        {
            Shell.Current.DisplayAlert("Error", "No se pudieron cargar los datos de los Departamentos ", "Aceptar");
            return new List<Departamento>();
        }
    }

    public async Task<List<Empleado>> GetEmpleadosAsync()
    {
        try
        {
            var empleados = await _httpClient.GetFromJsonAsync<List<Empleado>>("empleados/");
            return empleados ?? new List<Empleado>();
        }
        catch (Exception ex)
        {
            Shell.Current.DisplayAlert("Error", "No se pudieron cargar los datos de los empleados " , "Aceptar");
            return new List<Empleado>();
        }
    }

    public async Task<List<Sede>> GetSedesAsync()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<List<Sede>>("sedes/") ?? new List<Sede>();
        }
        catch(Exception ex) {
            Shell.Current.DisplayAlert("Error", "No se pudieron cargar los datos de las sedes ", "Aceptar");
            return new List<Sede>();
        }
    }
}
