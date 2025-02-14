using QualityExperienceUI.Data.Models.GetModels;
using QualityExperienceUI.Data.Models.PostModels;


namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IContextFieldCRUD
    {
        // Context Field Types
        Task<dynamic> GetContextFieldTypesBytemplate(int templateID);
        Task <dynamic> PostContextFieldType(PostContextFieldTypesdDTO contextFieldType);
        // Context Field Values
        Task<dynamic> GetContextFieldValuesByField(int fieldTypeID);
        Task<dynamic> PostContextFieldValue(PostContextFieldValuesDTO contextFieldValue);
        Task<dynamic> DeleteContextFieldValue(int FieldValueID);
    }
    public class ContextFieldCRUD : IContextFieldCRUD
    {
        // Middleware and Refit
        private readonly IApiMethods _IApiMethods;
        private readonly ApiMiddleware _apiMiddleware;

        public ContextFieldCRUD(IApiMethods apiMethods, ApiMiddleware apiMiddleware)
        {
            _IApiMethods = apiMethods;
            _apiMiddleware = apiMiddleware;
        }


        // GET
        // Get Context Field Types by template
        public async Task<dynamic> GetContextFieldTypesBytemplate(int templateID)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.GetContextFieldTypesByTemplateIdAsync(templateID));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return response.Data;
        }

        // Get Context Field Values by Field
        public async Task<dynamic> GetContextFieldValuesByField(int fieldTypeID)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.GetContextFieldValuesByContextTypeAsync(fieldTypeID));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return response.Data;
        }


        // POST
        // Post Context Field Types
        public async Task<dynamic> PostContextFieldType(PostContextFieldTypesdDTO contextFieldType)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.PostContextFieldTypesAsync(contextFieldType));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, unespected error has ocurred");
            }
            return true;
        }

        // Post Context Field Values
        public async Task<dynamic> PostContextFieldValue(PostContextFieldValuesDTO contextFieldValue)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.PostContextFieldValuesAsync(contextFieldValue));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, unespected error has ocurred");
            }
            return true;
        }


        // DELETE
        // Delete Context Field Value
        public async Task<dynamic> DeleteContextFieldValue(int FieldValueID)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.DeleteContextFieldValue(FieldValueID));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, unespected error has ocurred");
            }
            return true;
        }
    }
}
