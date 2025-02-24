using QualityExperienceUI.Data.Models.GetModels;
using QualityExperienceUI.Data.Models.PutModels;
using QualityExperienceUI.Data.Models.PostModels;
using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;



namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IQuestionsCRUD
    {
        Task<dynamic> GetAllQuestionsAsync();
        Task<dynamic> GetQuestionsByTemplateIdAsync(int templateId);
        Task<GetQuestionMetadataDTO> GetQuestionMetadata();
        Task<dynamic> putQuestionAsync(int questionId, PutQuestionDTO question);
        Task<dynamic> PostQuestionAsync(PostQuestionsDTO question);
        Task<dynamic> PostQuestionItemAsync(PostQuestionItemDTO questionItem);
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
        // Get all questions
        public async Task<dynamic> GetAllQuestionsAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.GetAllQuestionsAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return response.Data;
        }

        // Get all by templateId (groups included)
        public async Task<dynamic> GetQuestionsByTemplateIdAsync(int templateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.GetQuestionsByTemplateIdAsync(templateId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return response.Data;
        }

        // Get Metadata
        public async Task<GetQuestionMetadataDTO> GetQuestionMetadata()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.GetQuestionMetadataAsync());
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return response.Data;
        }


        // Put
        public async Task<dynamic> putQuestionAsync(int questionId, PutQuestionDTO question)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.PutQuestionAsync(questionId, question));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No item in database");
            }
            return true;
        }


        // Post
        public async Task<dynamic> PostQuestionAsync(PostQuestionsDTO question)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.PostQuestionAsync(question));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, unespected error has ocurred");
            }
            return true;
        }

        public async Task<dynamic> PostQuestionItemAsync (PostQuestionItemDTO questionitem)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.PostQuestionItemAsync(questionitem));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, unespected error has ocurred");
            }
            return true;
        }
    }
}
