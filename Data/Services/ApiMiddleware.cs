using Refit;
using System.Text.Json;

namespace QualityExperienceUI.Data.Services
{
    public class ApiMiddleware
    {
        private readonly IApiMethods _templateApi;

        public ApiMiddleware(IApiMethods templateApi)
        {
            _templateApi = templateApi;
        }


        // llamar a la API con manejo de errores centralizado.
        public async Task<(bool IsSuccess, T? Data, string? ErrorMessage)> ExecuteRequestAsync<T>(Func<Task<ApiResponse<T>>> apiCall)
        {
            try
            {
                // Ejecuta la llamada API
                var response = await apiCall();

                // Si la respuesta es exitosa, retorna los datos
                if (response.IsSuccessStatusCode)
                {
                    return (true, response.Content, null);
                }

                // Si no es exitosa, procesa el contenido del error
                var errorMessage = await ParseApiErrorFromResponseAsync(response);
                return (false, default, errorMessage);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones no controladas
                return (false, default, $"Ocurrió un error inesperado: {ex.Message}");
            }
        }


        // Método errores devueltos por la API.
        private async Task<string> ParseApiErrorFromResponseAsync<T>(ApiResponse<T> response)
        {
            if (response.Error != null)
            {
                try
                {
                    // Intenta deserializar el contenido del error
                    var errorResponse = JsonSerializer.Deserialize<ValidationErrorResponse>(response.Error.Content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (errorResponse?.Errors != null)
                    {
                        var errorMessages = errorResponse.Errors
                            .SelectMany(kvp => kvp.Value.Select(msg => $"{kvp.Key}: {msg}"))
                            .ToList();

                        return string.Join("\n", errorMessages);
                    }
                }
                catch
                {
                    return "Error inesperado al procesar la respuesta del servidor.";
                }
            }

            return $"Error {response.StatusCode}: {response.ReasonPhrase}";
        }
    }

    public class ValidationErrorResponse
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }
    }
    public class ApiErrorResponse
    {
        public string? code { get; set; }
        public string? message { get; set; }
    }
}
