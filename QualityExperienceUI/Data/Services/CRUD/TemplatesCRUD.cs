using QualityExperienceUI.Data.Models.Guideline.GetModels;
using QualityExperienceUI.Data.Models.Guideline.PostModels;
using QualityExperienceUI.Data.Models.Guideline.PutModels;
using QualityExperienceUI.Data.Validators;

namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface ITemplatesCRUD
    {
        Task<GetTemplateMetadataDTO> GetTemplatesMetadataAsync();
        Task<List<GetTemplatesDTO>> GetAllTemplatesAsync();
        Task<GetTemplateByIdDTO> GetTemplateByIdAsync(int templateId);
        Task <List<GetTemplatesByFiltersDTO>> GetAllTemplatesByFiltersAsync(int clientId, string? status, string? type, string? authorId, DateTime? startDate, DateTime? endDate);
        Task <GetServicesAssociatedByTemplateIdDTO> GetAllServicesAssociatedByTemplateIdAsync(int templateId);

        Task <bool> PutTemplateAsync(int templateId, PutTemplatesDTO template);
        Task<bool> PutServicesAssociatedByTemplateIdAsync(PutServicesAssociatedByTemplateIdDTO servicesAssociatedByTemplateId);

        Task<dynamic> PostTemplateAsync(PostTemplateDTO template);
        Task<bool> PostServicesAssociatedByTemplateIdAsync(PostServicesAssociatedByTemplateIdDTO servicesAssociatedByTemplateId);
    }

    public class TemplatesCRUD : ITemplatesCRUD
    {
        // Middleware and endpoints
        private readonly IApiEndpoints _apiEndpoints;
        private readonly ApiMiddleware _apiMiddleware;

        public TemplatesCRUD(IApiEndpoints apiEndpoints, ApiMiddleware apiMiddleware)
        {
            _apiEndpoints = apiEndpoints;
            _apiMiddleware = apiMiddleware;
        }


        // CRUD
        public async Task<GetTemplateMetadataDTO> GetTemplatesMetadataAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetTemplatesMetadataAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetTemplatesDTO>> GetAllTemplatesAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllTemplatesAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<GetTemplateByIdDTO> GetTemplateByIdAsync(int templateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetTemplateByIdAsync(templateId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetTemplatesByFiltersDTO>> GetAllTemplatesByFiltersAsync(int clientId, string? status, string? type, string? authorId, DateTime? startDate, DateTime? endDate)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetTemplatesByFiltersAsync(clientId, status, type, authorId, startDate, endDate));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<GetServicesAssociatedByTemplateIdDTO> GetAllServicesAssociatedByTemplateIdAsync(int templateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetServicesAssociatedByTemplateIdAsync(templateId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }



        public async Task<dynamic> PostTemplateAsync(PostTemplateDTO template)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostTemplateAsync(template));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.Data;
        }

        public async Task<bool> PostServicesAssociatedByTemplateIdAsync(PostServicesAssociatedByTemplateIdDTO servicesAssociatedByTemplateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostServicesAssociatedByTemplateIdAsync(servicesAssociatedByTemplateId));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }


        public async Task<bool> PutTemplateAsync(int templateId, PutTemplatesDTO template)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PutTemplateAsync(templateId, template));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }

        public async Task<bool> PutServicesAssociatedByTemplateIdAsync(PutServicesAssociatedByTemplateIdDTO servicesAssociatedByTemplateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PutServicesAssociatedByTemplateIdAsync(servicesAssociatedByTemplateId));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }
    }
}
