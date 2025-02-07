using Refit;
using QualityExperienceUI.Data.Models;

namespace QualityExperienceUI.Data.Services
{
    public interface IApiMethods
    {
        // Clients
        [Get("/api/clients")]
        Task<ApiResponse<IEnumerable<ClientListDTO>>> GetClientsAsync();



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



        // Services
        [Get("/api/services")]
        Task<ApiResponse<IEnumerable<ServiceListDTO>>> GetServicesAsync();

        [Get("/api/servicecategories")]
        Task<ApiResponse<IEnumerable<CategoriesListDTO>>> GetServicesCategories();

        [Get("/api/services-by-category/{id}")]
        Task<ApiResponse<IEnumerable<ServiceByCategorieListDTO>>> GetServicesByCategory(int id);



        // Indicators
        [Get("/api/indicators")]
        Task<ApiResponse<IEnumerable<IndicatorListDTO>>> Getindicators();



        // Questions
        [Get("/api/questions/metadata")]
        Task<ApiResponse<QuestionsMetadata>> GetQuestionsMetadataAsync();

        [Get("/api/templates/{id}/questions")]
        Task<ApiResponse<IEnumerable<QuestionsListByTemplateDTO>>> GetQuestionsByTemplate(int id);



        //For TemporalForms
        [Post("/api/clients")]
        Task<ApiResponse<HttpResponseMessage>> CreateClient([Body] CreateClientDTO client);

        [Post("/api/groups")]
        Task<ApiResponse<HttpResponseMessage>> CreateGroups([Body] CreateGroupDTO group);

        [Post("/api/indicators")]
        Task<ApiResponse<HttpResponseMessage>> Createindicator([Body] CreateIndicatorDTO indicator);

        [Post("/api/questions")]
        Task<ApiResponse<HttpResponseMessage>> CreateQuestion([Body] CreateQuestionsDTO question);

        [Post("/api/question-items")]
        Task<ApiResponse<HttpResponseMessage>> CreateQuestionItem([Body] CreateQuestionsItemDTO questionItem);

        [Post("/api/services")]
        Task<ApiResponse<HttpResponseMessage>> CreateService([Body] CreateServiceDTO service);

        [Post("/api/servicecategories")]
        Task<ApiResponse<HttpResponseMessage>> CreateServiceCategorie([Body] CreateServiceCategorieDTO serviceCategorie);




    }
}
