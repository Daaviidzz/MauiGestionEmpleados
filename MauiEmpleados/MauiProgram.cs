using LiveChartsCore.SkiaSharpView.Maui;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Microsoft.Extensions.Logging;
using MauiEmpleados.Services;
using MauiEmpleados.ViewModels;
using MauiEmpleados.Views;

namespace MauiEmpleados
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseLiveCharts()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ApiService>();
            builder.Services.AddTransient<EmpleadosViewModel>();
            builder.Services.AddTransient<DepartamentosViewModel>();
            builder.Services.AddTransient<SedesViewModel>();
            builder.Services.AddTransient<EmpleadoDetailViewModel>();
            builder.Services.AddTransient<SettingsViewModel>();
            builder.Services.AddTransient<EstadisticasViewModel>();
            builder.Services.AddTransient<EmpleadosPage>();
            builder.Services.AddTransient<DepartamentosPage>();
            builder.Services.AddTransient<SedesPage>();
            builder.Services.AddTransient<EmpleadoDetailPage>();
            builder.Services.AddTransient<SettingsPage>();
            builder.Services.AddTransient<EstadisticasPage>();
            return builder.Build();
        }
    }
}
