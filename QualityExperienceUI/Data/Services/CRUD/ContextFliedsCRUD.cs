using QualityExperienceUI.Data.Models.Guideline.GetModels;
using QualityExperienceUI.Data.Models.Guideline.PostModels;
using QualityExperienceUI.Data.Models.Guideline.PutModels;
using QualityExperienceUI.Data.Validators;
using System.Collections.Generic;

namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IContextFliedsCRUD
    {
        // Context types
        Task <List<GetContextFieldsTypesDTO>> GetContextFieldTypesBytemplateAsync(int templateId);
        Task<bool> PostContextFieldTypeAsync(PostContextFieldTypesdDTO contextFieldType);
        Task<bool> PutContextFieldTypeAsync(int id, PutContextFieldsTypesDTO contextFieldType);
        Task<bool> SoftDeleteContextFieldTypeAsync(int id);

        // Context values
        Task<List<GetContextFielValuesdDTO>> GetContextFieldValuesByFieldAsync(int contexttypeId);
        Task<bool> PostContextFieldValueAsync(PostContextFieldValuesDTO contextFieldValue);
        Task<bool> SoftDeleteContextFieldValueAsync(int id);
    }

    public class ContextFieldsCRUD : IContextFliedsCRUD
    {
        // Middleware and endpoints
        private readonly IApiEndpoints _apiEndpoints;
        private readonly ApiMiddleware _apiMiddleware;

        public ContextFieldsCRUD(IApiEndpoints apiEndpoints, ApiMiddleware apiMiddleware)
        {
            _apiEndpoints = apiEndpoints;
            _apiMiddleware = apiMiddleware;
        }


        // CRUD
        // Gets
        public async Task<List<GetContextFieldsTypesDTO>> GetContextFieldTypesBytemplateAsync(int templateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetContextFieldTypesByTemplateIdAsync(templateId));
            if (!response.IsSuccess || response.Data == null)
            {
                return new List<GetContextFieldsTypesDTO>();
            }
            return response.Data;
        }

        public async Task<List<GetContextFielValuesdDTO>> GetContextFieldValuesByFieldAsync(int contextTypeId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetContextFieldsValuesByContextTypeIdAsync(contextTypeId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        // Posts
        public async Task<bool> PostContextFieldTypeAsync(PostContextFieldTypesdDTO contextFieldType)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostContextFieldTypeAsync(contextFieldType));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return true;
        }

        public async Task<bool> PostContextFieldValueAsync(PostContextFieldValuesDTO contextFieldValue)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostContextFieldValueAsync(contextFieldValue));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return true;
        }

        // Puts
        public async Task<bool> PutContextFieldTypeAsync(int id, PutContextFieldsTypesDTO contextFieldType)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PutContextFieldTypeAsync(id, contextFieldType));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return true;
        }

        // Deletes
        public async Task<bool> SoftDeleteContextFieldTypeAsync(int id)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.SoftDeleteContextFieldTypeAsync(id));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return true;
        }

        public async Task<bool> SoftDeleteContextFieldValueAsync(int id)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.SoftDeleteContextFieldValueAsync(id));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return true;
        }
    }
}
