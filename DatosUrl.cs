using System.Text.Json.Serialization;

namespace LibClienteMeteo
{
	///
	/// <summary>
	/// Almacen de la URL fuente de los datos.
	/// </summary>
	/// <param name="Estado">
	/// Nos indice el estado de la respuesta: 200, 404.
	/// </param>
	/// <param name="URL">
	/// La URL fuente de los datos útiles.
	/// </param>
	///
	public record class DatosUrl(
        [property: JsonPropertyName("estado")] int Estado,
        [property: JsonPropertyName("datos")] string URL
    );
}