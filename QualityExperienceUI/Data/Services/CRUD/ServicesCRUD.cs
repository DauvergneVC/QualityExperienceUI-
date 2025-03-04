using QualityExperienceUI.Data.Models.Guideline.GetModels;
using QualityExperienceUI.Data.Models.Guideline.PostModels;
using QualityExperienceUI.Data.Validators;

namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IServicesCRUD
    {
        Task <List<GetServicesDTO>> GetAllServicesAsync ();
        Task<GetServicesDTO> GetServiceByIdAsync(int serviceId);
        Task <List<GetServicesByCategoryDTO>> GetAllServicesByCategoryAsync (int categoryId);
        Task<List<GetServiceCategoriesDTO>> GetAllServiceCategoriesAsync();

        Task<bool> PostServiceAsync(PostServiceDTO service);
        Task<bool> PostServiceCategoryAsync(PostServiceCategoryDTO serviceCategory);
    }

    public class ServicesCRUD : IServicesCRUD
    {
        // Middleware and endpoints
        private readonly IApiEndpoints _apiEndpoints;
        private readonly ApiMiddleware _apiMiddleware;

        public ServicesCRUD(IApiEndpoints apiEndpoints, ApiMiddleware apiMiddleware)
        {
            _apiEndpoints = apiEndpoints;
            _apiMiddleware = apiMiddleware;
        }


        // CRUD
        public async Task<List<GetServicesDTO>> GetAllServicesAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllServicesAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<GetServicesDTO> GetServiceByIdAsync(int serviceId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetServiceByIdAsync(serviceId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetServicesByCategoryDTO>> GetAllServicesByCategoryAsync(int categoryId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetServicesByCategoryIdAsync(categoryId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetServiceCategoriesDTO>> GetAllServiceCategoriesAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllServiceCategoriesAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }


        public async Task<bool> PostServiceAsync(PostServiceDTO service)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostServiceAsync(service));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }

        public async Task<bool> PostServiceCategoryAsync(PostServiceCategoryDTO serviceCategory)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostServiceCategoryAsync(serviceCategory));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }
    }
}
