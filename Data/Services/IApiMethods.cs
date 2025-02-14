using Refit;
using QualityExperienceUI.Data.Models; //-> Eliminar este luego 

using QualityExperienceUI.Data.Models.GetModels;
using QualityExperienceUI.Data.Models.PostModels;
using QualityExperienceUI.Data.Models.PutModels;


namespace QualityExperienceUI.Data.Services
{
    // EndPoints
    public interface IApiMethods
    {
        // Clients
        [Get("/api/clients")]
        Task<ApiResponse<IEnumerable<ClientListDTO>>> GetClientsAsync();

        [Get("/api/clients/{id}")]
        Task<ApiResponse<GetClientByIdDTO>> GetClientByIdAsync(int id);

        [Post("/api/clients")]
        Task<ApiResponse<HttpResponseMessage>> CreateClientAsync([Body] PostClientDTO client);

        [Put("/api/clients/{id}")]
        Task<ApiResponse<HttpResponseMessage>> UpdateClientAsync(int id, [Body] PutClientDTO client);



        // Groups
        [Get("/api/group-metadata")]
        Task<ApiResponse<GetGroupMetadataDTO>> GetGroupsMetadataAsync();

        [Get("/api/groups")]
        Task<ApiResponse<List<GetGroupListDTO>>> GetGroupsAsync();

        [Post("/api/groups")]
        Task<ApiResponse<HttpResponseMessage>> CreateGroupAsync([Body] CreateGroupDTO group);

        [Put("/api/groups/{id}")]
        Task<ApiResponse<HttpResponseMessage>> UpdateGroupAsync(int id, [Body] PutGroupDTO group);



        // SERVICES
        // Get
        [Get("/api/services")]
        Task<ApiResponse<List<GetServiceDTO>>> GetServicesAsync();

        [Get("/api/servicecategories")]
        Task<ApiResponse<List<GetServiceCategoriesDTO>>> GetServicesCategories();

        [Get("/api/services-by-category/{id}")]
        Task<ApiResponse<List<GetServiceByCategoryDTO>>> GetServicesByCategory(int id);

        // Put
        [Put("/api/services/{id}")]
        Task<ApiResponse<HttpResponseMessage>> UpdateServiceAsync(int id, [Body] PutServiceDTO service);

        [Put("/api/servicecategories/{id}")]
        Task<ApiResponse<HttpResponseMessage>> UpdateServiceCattegory(int id, [Body] PutServiceCategoryDTO category);

        // Post
        [Post("/api/services")]
        Task<ApiResponse<HttpResponseMessage>> CreateServiceAsync([Body] PostServicesDTO service);

        [Post("/api/servicecategories")]
        Task<ApiResponse<HttpResponseMessage>> CreateServiceCategoryAsync([Body] PostServicesCategoriesDTO category);



        // Indicators
        [Get("/api/indicators")]
        Task<ApiResponse<List<GetIndicatorDTO>>> GetIndicatorsAsync();

        [Get("/api/indicators/{id}")]
        Task<ApiResponse<GetIndicatorDTO>> GetIndicatorByIdAsync(int id);

        [Put("/api/indicators/{id}")]
        Task<ApiResponse<HttpResponseMessage>> UpdateIndicatorAsync(int id, [Body] PutIndicatorDTO indicator);

        [Post("/api/indicators")]
        Task<ApiResponse<HttpResponseMessage>> CreateIndicatorAsync([Body] PostIndicatorDTO indicator);



        // Templates
        [Get("/api/templates")]
        Task<ApiResponse<IEnumerable<TemplateListDto>>> GetTemplatesAsync();

        [Get("/api/templates/{id}")]
        Task<ApiResponse<TemplateListByIDDto>> GetTemplatesByIDAsync(int id);

        [Get("/api/templates/by-filters")]
        Task<ApiResponse<IEnumerable<TemplateListDto>>> GetTemplatesByFiltersAsync(
            [AliasAs("clientID")] int clientID,
            [AliasAs("status")] string? status,
            [AliasAs("type")] string? type,
            [AliasAs("authorID")] string? authorID,
            [AliasAs("startDate")] DateTime? startDate,
            [AliasAs("endDate")] DateTime? endDate
        );

        [Get("/api/templates/metadata")]
        Task<ApiResponse<TemplateOptionsDto>> GetTemplateOptionsAsync();


        [Post("/api/templates")]
        Task<ApiResponse<HttpResponseMessage>> CreateTemplateAsync([Body] TemplateCreateDto template);


        [Put("/api/templates/{id}")]
        Task<ApiResponse<HttpResponseMessage>> UpdateTemplateAsync(int id, [Body] TemplateUpdateDTO template);


        [Delete("/api/template-soft/{id}")]
        Task<ApiResponse<HttpResponseMessage>> SoftDeleteTemplate(int id);

        [Delete("/api/template/{id}")]
        Task<ApiResponse<HttpResponseMessage>> DeleteTemplate(int id);



        // ContextFields
        //Get
        [Get("/api/context-field-types/{id}")]
        Task<ApiResponse<List<GetContextFieldTypesDTO>>> GetContextFieldTypesByTemplateIdAsync(int id);

        [Get("/api/context-field-values/{id}")]
        Task<ApiResponse<List<GetConextxFielValuesdDTO>>> GetContextFieldValuesByContextTypeAsync(int id);

        // Post
        [Post("/api/contextFieldTypes")]
        Task<ApiResponse<HttpResponseMessage>> PostContextFieldTypesAsync([Body] PostContextFieldTypesdDTO contextFieldTypes);

        [Post("/api/contextfieldvalues")]
        Task<ApiResponse<HttpResponseMessage>> PostContextFieldValuesAsync([Body] PostContextFieldValuesDTO contextFieldValues);

        // Delete
        [Delete("/api/context-field-value/{id}")]
        Task<ApiResponse<HttpResponseMessage>> DeleteContextFieldValue(int id);



        // Questions
        // Get
        [Get("/api/templates/{id}/questions")]
        Task <ApiResponse<List<GetQuestionsByTemplateIdDTO>>> GetQuestionsByTemplateIdAsync(int id);
    }
}
