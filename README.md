
# Maui Gestión de Empleados

Una aplicación moderna de gestión de empleados desarrollada con **.NET MAUI**, diseñada para proporcionar un directorio corporativo completo y profesional.

---

## Descripción del Proyecto

**Maui Gestión de Empleados** es una solución multiplataforma que permite a las empresas gestionar y visualizar información detallada sobre sus empleados, departamentos y sedes de manera eficiente. Con una interfaz intuitiva y responsiva, esta aplicación proporciona herramientas esenciales para la administración de recursos humanos.

### Características Principales

-  **Gestión de Empleados**: Visualiza, busca y consulta información detallada de todos los empleados
-  **Departamentos**: Organiza y visualiza empleados por departamentos
-  **Sedes**: Gestiona múltiples ubicaciones y sedes corporativas
-  **Estadísticas**: Análisis gráficos y reportes de datos con LibreCharts
-  **Configuración**: Panel de ajustes personalizables
-  **Diseño Responsivo**: Funciona perfectamente en móviles, tablets y escritorio

---

##  Tecnologías Utilizadas

- **Lenguaje**: C#
- **Framework**: .NET MAUI (Multi-platform App UI)
- **Arquitectura**: MVVM (Model-View-ViewModel)
- **Gráficos**: LiveChartsCore con SkiaSharp
- **API**: Integración con servicios backend
- **Inyección de Dependencias**: Microsoft.Extensions.DependencyInjection

### Stack Técnico Completo

```
.NET MAUI
├── ViewModels (MVVM)
├── Views (UI)
├── Models (Entidades)
├── Services (Lógica de negocio)
└── Resources (Estilos y Recursos)
```

---

## Vista Previa de la Aplicación

### Interfaz Principal

<img width="1912" height="973" alt="image" src="https://github.com/user-attachments/assets/124e9da9-6b57-4573-8fd0-2e9c30de18ab" />


### Módulos Principales

**Pantalla de Empleados** 
- Listado completo de empleados
- Búsqueda y filtrado
- Información detallada de cada empleado
- Navegación intuitiva

**Panel de Estadísticas** 
- Gráficos interactivos en tiempo real
- Distribución por departamentos
- Distribución por sedes
- Métricas clave de la organización

**Gestión de Departamentos** 
- Vista jerárquica
- Empleados asignados
- Información detallada

**Gestión de Sedes** 
- Ubicaciones corporativas
- Empleados por ubicación
- Datos geográficos

---

##  Funcionalidades

### Gestión de Datos
- ✅ Consultar empleados con información detallada
- ✅ Visualizar estructura organizacional
- ✅ Filtrar y buscar empleados
- ✅ Ver estadísticas en tiempo real

### Interfaz de Usuario
- ✅ Navegación tipo Flyout Menu
- ✅ Diseño limpio y moderno
- ✅ Iconos descriptivos y emojis
- ✅ Experiencia responsive en todos los dispositivos

### Análisis y Reportes
- ✅ Gráficos estadísticos interactivos
- ✅ Información visual de datos corporativos
- ✅ Análisis por departamento
- ✅ Análisis por sede

---

##  Estructura del Proyecto

```
MauiGestionEmpleados/
├── MauiEmpleados/
│   ├── Views/                  # Páginas UI (XAML)
│   │   ├── EmpleadosPage.xaml
│   │   ├── DepartamentosPage.xaml
│   │   ├── SedesPage.xaml
│   │   ├── EstadisticasPage.xaml
│   │   ├── SettingsPage.xaml
│   │   └── EmpleadoDetailPage.xaml
│   ├── ViewModels/             # Lógica de presentación
│   │   ├── EmpleadosViewModel.cs
│   │   ├── DepartamentosViewModel.cs
│   │   ├── SedesViewModel.cs
│   │   ├── EstadisticasViewModel.cs
│   │   ├── SettingsViewModel.cs
│   │   └── EmpleadoDetailViewModel.cs
│   ├── Models/                 # Modelos de datos
│   │   ├── Empleado.cs
│   │   ├── Departamento.cs
│   │   └── Sede.cs
│   ├── Services/               # Servicios (API, Datos)
│   │   └── ApiService.cs
│   ├── Resources/              # Fuentes y estilos
│   ├── AppShell.xaml           # Navegación principal
│   ├── App.xaml                # Configuración global
│   └── MauiProgram.cs          # Punto de entrada
├── MauiEmpleados.csproj        # Archivo de proyecto
└── README.md
```

---

##  Configuración e Instalación

### Requisitos Previos

- Visual Studio 2022 o superior
- .NET 8 SDK o superior
- MAUI Workload instalado

### Instalación del Workload MAUI

```bash
dotnet workload restore
```

### Clonar el Repositorio

```bash
git clone https://github.com/Daaviidzz/MauiGestionEmpleados.git
cd MauiGestionEmpleados
```

### Restaurar Dependencias

```bash
dotnet restore
```

### Compilar la Solución

```bash
dotnet build
```

### Ejecutar la Aplicación

**Windows:**
```bash
dotnet build -f net8.0-windows
```

**Android:**
```bash
dotnet build -f net8.0-android
```

**iOS (macOS):**
```bash
dotnet build -f net8.0-ios
```

**macOS:**
```bash
dotnet build -f net8.0-macos
```

---

##  Dependencias

```xml
<!-- LiveCharts para gráficos estadísticos -->
<PackageReference Include="LiveChartsCore.SkiaSharpView.Maui" />

<!-- SkiaSharp para renderizado gráfico -->
<PackageReference Include="SkiaSharp.Views.Maui.Controls.Hosting" />

<!-- .NET MAUI Framework -->
<PackageReference Include="Microsoft.Maui.Controls" />
<PackageReference Include="Microsoft.Maui.Controls.Hosting" />
```

---

---

##  Mejoras Futuras

- [ ] Integración de autenticación y autorización
- [ ] Edición y eliminación de registros
- [ ] Exportación a PDF/Excel
- [ ] Búsqueda avanzada
- [ ] Sincronización con Active Directory
- [ ] Notificaciones en tiempo real
- [ ] Soporte para múltiples idiomas

---

## Contribuciones

Las contribuciones son bienvenidas. Para cambios importantes:

1. Fork del repositorio
2. Crear rama de feature (`git checkout -b feature/AmazingFeature`)
3. Commit de cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abrir un Pull Request

---

## Soporte y Contacto

Si encuentras problemas o tienes sugerencias:

-  Abre un Issue en el repositorio
-  Revisa las discussiones
-  Reporta bugs detalladamente

---

## Licencia

Este proyecto está disponible bajo licencia abierta. Consulta el archivo LICENSE para más detalles.

---

## Reconocimientos

Desarrollado con .NET MAUI

- **Framework**: Microsoft .NET MAUI
- **Gráficos**: LiveChartsCore
- **Renderizado**: SkiaSharp

---

## Estadísticas del Proyecto

- **Lenguaje**: 100% C#
- **Tipo**: Aplicación Multiplataforma
- **Patrón**: MVVM
- **Plataformas**: Windows, macOS, iOS, Android

---

**Última actualización**: Febrero 2026
**Estado**: En desarrollo activo ✅
