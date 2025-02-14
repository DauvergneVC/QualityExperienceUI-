using AntDesign;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.Extensions.Localization;
using QualityExperienceUI.Data.Models.GetModels;
using QualityExperienceUI.Data.Models.PostModels;
using QualityExperienceUI.Data.Models.PutModels;


namespace QualityExperienceUI.Data.Services.CRUD
{
    // Interface
    public interface IServiceCRUD
    {
        Task<dynamic> GetServicesCategories();
        Task<dynamic> PostService(PostServicesDTO service);
        Task<dynamic> PostServiceCategory(PostServicesCategoriesDTO category);
        Task<dynamic> PutServiceCategory(int id, PutServiceCategoryDTO category);
    }


    // CRUD
    public class ServicesCRUD : IServiceCRUD
    {
        // Interfaces methods
        private readonly IApiMethods _IApiMethods;
        private readonly ApiMiddleware _apiMiddleware;

        public ServicesCRUD(IApiMethods apiMethods, ApiMiddleware apiMiddleware)
        {
            _IApiMethods = apiMethods;
            _apiMiddleware = apiMiddleware;
        }


        // GET
        // Get categories
        public async Task<dynamic> GetServicesCategories()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.GetServicesCategories());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return response.Data;
        }


        // POST
        // Post services
        public async Task<dynamic> PostService(PostServicesDTO service)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.CreateServiceAsync(service));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return true;
        }
        // Post service categories
        public async Task<dynamic> PostServiceCategory(PostServicesCategoriesDTO category)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.CreateServiceCategoryAsync(category));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return true;
        }

        // PUT
        // Put services categories
        public async Task<dynamic> PutServiceCategory(int id, PutServiceCategoryDTO category)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.UpdateServiceCattegory(id, category));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return true;
        }
    }
}
