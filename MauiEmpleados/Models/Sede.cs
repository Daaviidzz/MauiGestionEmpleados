using System.Text.Json.Serialization;

namespace MauiEmpleados.Models;

public class Sede
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName ("nombre")]
    public string? Nombre { get; set; }

}
