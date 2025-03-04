using QualityExperienceUI.Data.Models.Guideline.GetModels;
using QualityExperienceUI.Data.Models.Guideline.PostModels;
using QualityExperienceUI.Data.Validators;

namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IGroupsCRUD
    {
        Task<GetGroupMetadataDTO> GetGroupMetadataAsync();
        Task<List<GetGroupsDTO>> GetAllGroupsAsync();
        Task<List<GetGroupsByTemplateDTO>> GetGroupsByTemplateAsync(int templateId);
        Task<bool> PostGroupAsync(PostGroupDTO group);
    }

    public class GroupsCRUD : IGroupsCRUD
    {
        // Middleware and endpoints
        private readonly IApiEndpoints _apiEndpoints;
        private readonly ApiMiddleware _apiMiddleware;

        public GroupsCRUD(IApiEndpoints apiEndpoints, ApiMiddleware apiMiddleware)
        {
            _apiEndpoints = apiEndpoints;
            _apiMiddleware = apiMiddleware;
        }


        // CRUD
        public async Task<GetGroupMetadataDTO> GetGroupMetadataAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetGroupMetadataAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetGroupsDTO>> GetAllGroupsAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllGroupsAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetGroupsByTemplateDTO>> GetGroupsByTemplateAsync(int templateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetGroupsByTemplateIdAsync(templateId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }


        public async Task<bool> PostGroupAsync(PostGroupDTO group)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostGroupAsync(group));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return true;

        }
    }
}
