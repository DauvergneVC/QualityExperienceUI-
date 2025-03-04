using Refit;
using QualityExperienceUI.Data.Models.Guideline.PostModels;
using QualityExperienceUI.Data.Models.Guideline.GetModels;
using QualityExperienceUI.Data.Models.Guideline.PutModels;


namespace QualityExperienceUI.Data.Services
{
    public interface IApiEndpoints
    {
        // CLIENTS
        // Gets
        [Get("/api/clients")]
        Task<ApiResponse<List<GetClientDTO>>> GetAllClientsAsync();

        [Get("/api/clients/{clientId}")]
        Task<ApiResponse<GetClientByIdDTO>> GetClientByIdAsync(int clientId);

        // Posts
        [Post("/api/clients")]
        Task<ApiResponse<HttpResponse>> PostClientAsync([Body] PostClientDTO client);



        // CONTEXT FIELDS
        // Gets
        [Get("/api/context-field-types/{templateId}")]
        Task<ApiResponse<List<GetContextFieldsTypesDTO>>> GetContextFieldTypesByTemplateIdAsync(int templateId);

        [Get("/api/context-field-values/{contextFieldTypeId}")]
        Task<ApiResponse<List<GetContextFielValuesdDTO>>> GetContextFieldsValuesByContextTypeIdAsync(int contextFieldTypeId);

        // Posts
        [Post("/api/contextFieldTypes")]
        Task<ApiResponse<HttpResponse>> PostContextFieldTypeAsync([Body] PostContextFieldTypesdDTO contextFieldType);

        [Post("/api/contextfieldvalues")]
        Task<ApiResponse<HttpResponse>> PostContextFieldValueAsync([Body] PostContextFieldValuesDTO contextFieldValue);

        // Puts
        [Put("/api/contextFieldTypes/{id}")]
        Task<ApiResponse<HttpResponse>> PutContextFieldTypeAsync(int id, [Body] PutContextFieldsTypesDTO contextFieldType);

        // Deletes
        [Delete("/api/context-field-types-soft/{id}")]
        Task<ApiResponse<HttpResponse>> SoftDeleteContextFieldTypeAsync(int id);

        [Delete("/api/context-field-value-soft/{id}")]
        Task<ApiResponse<HttpResponse>> SoftDeleteContextFieldValueAsync(int id);



        // COUNTRIES
        [Get("/api/countries")]
        Task<ApiResponse<List<GetCountriesDTO>>> GetAllCountriesAsync();



        // GROUPS
        // Gets
        [Get("/api/groups")]
        Task<ApiResponse<List<GetGroupsDTO>>> GetAllGroupsAsync();

        [Get("/api/group-metadata")]
        Task<ApiResponse<GetGroupMetadataDTO>> GetGroupMetadataAsync();

        [Get("/api/templates/{templateID}/groups")]
        Task<ApiResponse<List<GetGroupsByTemplateDTO>>> GetGroupsByTemplateIdAsync(int templateID);

        // Post
        [Post("/api/groups")]
        Task<ApiResponse<HttpResponse>> PostGroupAsync([Body] PostGroupDTO group);



        // INDICATORS
        // Gets
        [Get("/api/indicators")]
        Task<ApiResponse<List<GetIndicatorsDTO>>> GetAllIndicatorsAsync();

        [Get("/api/indicators/{indicatorId}")]
        Task<ApiResponse<GetIndicatorsDTO>> GetIndicatorByIdAsync(int indicatorId);

        // Posts
        [Post("/api/indicators")]
        Task<ApiResponse<HttpResponse>> PostIndicatorAsync([Body] PostIndicatorDTO indicator);



        // QUESTIONS
        // Gets
        [Get("/api/questions")]
        Task<ApiResponse<List<GetQuestionsDTO>>> GetAllQuestionsAsync();

        [Get("/api/templates/{templateId}/questions")]
        Task<ApiResponse<List<GetQuestionsByTemplateIdDTO>>> GetAllQuestionDataByTemplateIdAsync(int templateId);

        [Get("/api/questions/metadata")]
        Task<ApiResponse<GetQuestionMetadataDTO>> GetQuestionsMetadataAsync();

        [Get("/api/question-evaluation-controls")]
        Task<ApiResponse<List<GetQuestionsEvaluationControlsDTO>>> GetAllQuestionEvaluationControlsAsync();

        [Get("/api/question-item-list-values/{id}")]
        Task<ApiResponse<List<GetQuestionItemListValuesDTO>>> GetAllQuestionItemListValuesFromQuestionItemAsync(int id);

        // Posts
        [Post("/api/questions")]
        Task<ApiResponse<HttpResponse>> PostQuestionAsync([Body] PostQuestionDTO question);

        [Post("/api/question-items")]
        Task<ApiResponse<HttpResponse>> PostQuestionItemAsync([Body] PostQuestionItemDTO questionItem);

        [Post("/api/question-item-list-value")]
        Task<ApiResponse<HttpResponse>> PostQuestionItemListValueAsync([Body] PostQuestionItemListValueDTO questionItemListValue);

        // Puts
        [Put("/api/questions/{id}")]
        Task<ApiResponse<HttpResponse>> PutQuestionAsync(int id, [Body] PutQuestionsDTO question);

        [Put("/api/question-items/{id}")]
        Task<ApiResponse<HttpResponse>> PutQuestionItemAsync(int id, [Body] PutQuestionItemDTO questionItem);



        // SERVICES
        // Gets
        [Get("/api/services")]
        Task<ApiResponse<List<GetServicesDTO>>> GetAllServicesAsync();

        [Get("/api/services/{id}")]
        Task<ApiResponse<GetServicesDTO>> GetServiceByIdAsync(int id);

        [Get("/api/services-by-category/{id}")]
        Task<ApiResponse<List<GetServicesByCategoryDTO>>> GetServicesByCategoryIdAsync(int id);

        [Get("/api/servicecategories")]
        Task<ApiResponse<List<GetServiceCategoriesDTO>>> GetAllServiceCategoriesAsync();

        // Posts
        [Post("/api/services")]
        Task<ApiResponse<HttpResponse>> PostServiceAsync([Body] PostServiceDTO service);

        [Post("/api/servicecategories")]
        Task<ApiResponse<HttpResponse>> PostServiceCategoryAsync([Body] PostServiceCategoryDTO serviceCategory);



        // TEMPLATES
        // Gets
        [Get("/api/templates")]
        Task<ApiResponse<List<GetTemplatesDTO>>> GetAllTemplatesAsync();

        [Get("/api/templates/by-filters")]
        Task<ApiResponse<List<GetTemplatesByFiltersDTO>>> GetTemplatesByFiltersAsync(
            [AliasAs("clientID")] int clientID,
            [AliasAs("status")] string? status,
            [AliasAs("type")] string? type,
            [AliasAs("authorID")] string? authorID,
            [AliasAs("startDate")] DateTime? startDate,
            [AliasAs("endDate")] DateTime? endDate
        );

        [Get("/api/templates/metadata")]
        Task<ApiResponse<GetTemplateMetadataDTO>> GetTemplatesMetadataAsync();

        [Get("/api/templates/{id}")]
        Task<ApiResponse<GetTemplateByIdDTO>> GetTemplateByIdAsync(int id);

        [Get("/api/templates-services/{templateId}")]
        Task<ApiResponse<GetServicesAssociatedByTemplateIdDTO>> GetServicesAssociatedByTemplateIdAsync(int templateId);

        // Posts
        [Post("/api/templates")]
        Task<ApiResponse<HttpResponse>> PostTemplateAsync([Body] PostTemplateDTO template);

        [Post("/api/templates-services")]
        Task<ApiResponse<HttpResponse>> PostServicesAssociatedByTemplateIdAsync([Body] PostServicesAssociatedByTemplateIdDTO servicesAssociatedByTemplateId);

        // Puts
        [Put("/api/templates/{id}")]
        Task<ApiResponse<HttpResponse>> PutTemplateAsync(int id, [Body] PutTemplatesDTO template);

        [Put("/api/templates-services")]
        Task<ApiResponse<HttpResponse>> PutServicesAssociatedByTemplateIdAsync([Body] PutServicesAssociatedByTemplateIdDTO servicesAssociatedByTemplateId);
    }
}
