using QualityExperienceUI.Data.Models.Guideline.GetModels;
using QualityExperienceUI.Data.Models.Guideline.PostModels;
using QualityExperienceUI.Data.Validators;

namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IClientsCRUD
    {
        Task<List<GetClientDTO>> GetAllClientsAsync();
        // Include get countries
        Task<List<GetCountriesDTO>> GetAllCountriesAsync();

        Task<bool> PostClientAsync(PostClientDTO client);

    }

    public class ClientsCRUD : IClientsCRUD
    {
        // Middleware and endpoints
        private readonly IApiEndpoints _apiEndpoints;
        private readonly ApiMiddleware _apiMiddleware;

        public ClientsCRUD(IApiEndpoints apiEndpoints, ApiMiddleware apiMiddleware)
        {
            _apiEndpoints = apiEndpoints;
            _apiMiddleware = apiMiddleware;
        }


        // CRUD
        public async Task<List<GetClientDTO>> GetAllClientsAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllClientsAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetCountriesDTO>> GetAllCountriesAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllCountriesAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }



        public async Task<bool> PostClientAsync(PostClientDTO client)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostClientAsync(client));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return true;
        }
    }
}
