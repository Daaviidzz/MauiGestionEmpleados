using System.Text.Json.Serialization;

namespace MauiEmpleados.Models;

public class Departamento
{

    [JsonPropertyName("id")]
    public int? Id { get; set; }
    [JsonPropertyName("nombre")]
    public string? Nombre { get; set; }

    [JsonPropertyName ("ganancias")]
    public float? Ganancias { get; set; }
    [JsonPropertyName("sede_id")]
    public int? SedeId { get; set; }


}
