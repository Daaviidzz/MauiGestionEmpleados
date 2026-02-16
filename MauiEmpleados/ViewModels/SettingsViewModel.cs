using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiEmpleados.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    [ObservableProperty]
    private bool recibirNotificaciones = true;

    [ObservableProperty]
    private string versionApp = "1.0.0";


    [ObservableProperty]
    private List<AppTheme> _temas = new() { AppTheme.Unspecified, AppTheme.Light, AppTheme.Dark };

    [ObservableProperty]
    private AppTheme _temaSeleccionado = Application.Current.UserAppTheme;

    [RelayCommand]
    private void SaveSettings() => Application.Current.UserAppTheme = TemaSeleccionado;
}