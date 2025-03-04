using QualityExperienceUI.Data.Models.Guideline.GetModels;
using QualityExperienceUI.Data.Models.Guideline.PostModels;
using QualityExperienceUI.Data.Validators;

namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IIndicatorsCRUD
    {
        Task <List<GetIndicatorsDTO>> GetAllIndicatorsAsync();
        Task<GetIndicatorsDTO> GetIndicatorByIdAsync(int indicatorId);
        Task<bool> PostIndicatorAsync(PostIndicatorDTO indicator);
    }

    public class IndicatorsCRUD : IIndicatorsCRUD
    {
        // Middleware and endpoints
        private readonly IApiEndpoints _apiEndpoints;
        private readonly ApiMiddleware _apiMiddleware;

        public IndicatorsCRUD(IApiEndpoints apiEndpoints, ApiMiddleware apiMiddleware)
        {
            _apiEndpoints = apiEndpoints;
            _apiMiddleware = apiMiddleware;
        }


        // CRUD
        public async Task<List<GetIndicatorsDTO>> GetAllIndicatorsAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllIndicatorsAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<GetIndicatorsDTO> GetIndicatorByIdAsync(int indicatorId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetIndicatorByIdAsync(indicatorId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }


        public async Task<bool> PostIndicatorAsync(PostIndicatorDTO indicator)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostIndicatorAsync(indicator));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }
    }
}
