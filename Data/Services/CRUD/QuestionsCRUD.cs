using QualityExperienceUI.Data.Models.GetModels;


namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IQuestionsCRUD
    {
        Task<dynamic> GetQuestionsByTemplateIdAsync(int templateId);
    }

    public class QuestionsCRUD : IQuestionsCRUD
    {
        // Middleware and Refit
        private readonly IApiMethods _IApiMethods;
        private readonly ApiMiddleware _apiMiddleware;

        public QuestionsCRUD(IApiMethods apiMethods, ApiMiddleware apiMiddleware)
        {
            _IApiMethods = apiMethods;
            _apiMiddleware = apiMiddleware;
        }


        // Get
        public async Task<dynamic> GetQuestionsByTemplateIdAsync(int templateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.GetQuestionsByTemplateIdAsync(templateId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return response.Data;
        }
    }
}
