using QualityExperienceUI.Data.Models.Guideline.GetModels;
using QualityExperienceUI.Data.Models.Guideline.PostModels;
using QualityExperienceUI.Data.Models.Guideline.PutModels;
using QualityExperienceUI.Data.Validators;

namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IQuestionsCRUD
    {
        Task <GetQuestionMetadataDTO> GetQuestionMetadataAsync ();
        Task<List<GetQuestionsDTO>> GetAllQuestionsAsync();
        Task<List<GetQuestionsByTemplateIdDTO>> GetAllQuestionDataByTemplateIdAsync(int templateId);
        Task<List<GetQuestionsEvaluationControlsDTO>> GetAllQuestionsEvaluationControlsAsync();
        Task<List<GetQuestionItemListValuesDTO>> GetAllQuestionItemListValuesFromQuestionItemAsync(int id);

        Task<bool> PostQuestionAsync(PostQuestionDTO question);
        Task<bool> PostQuestionItemAsync(PostQuestionItemDTO questionItem);
        Task<bool> PostQuestionItemListValueAsync(PostQuestionItemListValueDTO questionItemListValue);

        Task<bool> PutQuestionAsync(int id, PutQuestionsDTO question);
        Task<bool> PutQuestionItemAsync(int id, PutQuestionItemDTO questionItem);
    }

    public class QuestionsCRUD : IQuestionsCRUD
    {
        // Middleware and endpoints
        private readonly IApiEndpoints _apiEndpoints;
        private readonly ApiMiddleware _apiMiddleware;

        public QuestionsCRUD(IApiEndpoints apiEndpoints, ApiMiddleware apiMiddleware)
        {
            _apiEndpoints = apiEndpoints;
            _apiMiddleware = apiMiddleware;
        }


        // CRUD
        public async Task<GetQuestionMetadataDTO> GetQuestionMetadataAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetQuestionsMetadataAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetQuestionsDTO>> GetAllQuestionsAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllQuestionsAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetQuestionsByTemplateIdDTO>> GetAllQuestionDataByTemplateIdAsync(int templateId)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllQuestionDataByTemplateIdAsync(templateId));
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetQuestionsEvaluationControlsDTO>> GetAllQuestionsEvaluationControlsAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllQuestionEvaluationControlsAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data found in database");
            }
            return response.Data;
        }

        public async Task<List<GetQuestionItemListValuesDTO>> GetAllQuestionItemListValuesFromQuestionItemAsync(int id)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.GetAllQuestionItemListValuesFromQuestionItemAsync(id));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage ?? "Exception");
            }
            return response.Data ?? new List<GetQuestionItemListValuesDTO>();
        }


        public async Task<bool> PostQuestionAsync(PostQuestionDTO question)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostQuestionAsync(question));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }

        public async Task<bool> PostQuestionItemAsync(PostQuestionItemDTO questionItem)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostQuestionItemAsync(questionItem));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }

        public async Task<bool> PostQuestionItemListValueAsync(PostQuestionItemListValueDTO questionItemListValue)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PostQuestionItemListValueAsync(questionItemListValue));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }


        public async Task<bool> PutQuestionAsync(int id, PutQuestionsDTO question)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PutQuestionAsync(id, question));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }

        public async Task<bool> PutQuestionItemAsync(int id, PutQuestionItemDTO questionItem)
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _apiEndpoints.PutQuestionItemAsync(id, questionItem));
            if (!response.IsSuccess)
            {
                throw new Exception(response.ErrorMessage);
            }
            return response.IsSuccess;
        }
    }
}
