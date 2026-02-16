using System.Text.Json.Serialization;

namespace MauiEmpleados.Models;

public class Empleado
{
    //Esto le dice al programa: Busca 'id' en el JSON pero guardalo en la propiedad 'Id' (por la mayusculas y eso)
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("nombre")]
    public string? Nombre { get; set; }

    [JsonPropertyName("apellido")]
    public string? Apellido { get; set; }

    [JsonPropertyName("genero")]
    public string? Genero { get; set; }

    [JsonPropertyName("edad")]
    public int? Edad { get; set; }

    [JsonPropertyName("imagen_uri")]
    public string? ImagenUri { get; set; }

    [JsonPropertyName("departamento_id")]
    public int? DepartamentoId { get; set; }
}

