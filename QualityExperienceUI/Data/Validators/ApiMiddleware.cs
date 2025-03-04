using QualityExperienceUI.Data.Services;
using Refit;
using System.Text.Json;

namespace QualityExperienceUI.Data.Validators
{
    public class ApiMiddleware
    {
        private readonly IApiEndpoints _apiEndpoints;

        public ApiMiddleware(IApiEndpoints apiEndpoints)
        {
            _apiEndpoints = apiEndpoints;
        }


        // Call ApiEndpoints and manage errors
        public async Task<(bool IsSuccess, T? Data, string? ErrorMessage)> ExecuteRequestAsync<T>(Func<Task<ApiResponse<T>>> apiCall)
        {
            try
            {
                // Execute a call
                var response = await apiCall();

                // Return Data and true if is success
                if (response.IsSuccessStatusCode)
                {
                    return (true, response.Content, null);
                }

                // if isn't success, prosses error content
                var errorMessage = await ParseApiErrorFromResponseAsync(response);
                return (false, default, errorMessage);
            }
            catch (Exception ex)
            {
                // uncontrolled errors
                return (false, default, $"Ocurrió un error inesperado: {ex.Message}");
            }
        }


        // Handle errors returned from BackEnd
        private Task<string> ParseApiErrorFromResponseAsync<T>(ApiResponse<T> response)
        {
            if (response.Error != null && response.Error.Content != null)
            {
                try
                {
                    // Deserialize errors
                    var errorResponse = JsonSerializer.Deserialize<ValidationErrorResponse>(response.Error.Content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (errorResponse?.Errors != null)
                    {
                        var errorMessages = errorResponse.Errors
                            .SelectMany(kvp => kvp.Value.Select(msg => $"{kvp.Key}: {msg}"))
                            .ToList();

                        return Task.FromResult(string.Join("\n", errorMessages));
                    }
                }
                catch
                {
                    return Task.FromResult("Error inesperado al procesar la respuesta del servidor.");
                }
            }
            return Task.FromResult($"Error {response.StatusCode}: {response.ReasonPhrase}");
        }

    }

    public class ValidationErrorResponse
    {
        public string? Type { get; set; }
        public string? Title { get; set; }
        public int Status { get; set; }
        public Dictionary<string, List<string>>? Errors { get; set; }
    }
}
