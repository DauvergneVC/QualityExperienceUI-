namespace QualityExperienceUI.Data.Services.CRUD
{
    public interface IGroupsCRUD
    {
        Task<dynamic> GetAllGroupsAsync();
    }


    public class GroupsCRUD : IGroupsCRUD
    {
        private readonly IApiMethods _IApiMethods;
        private readonly ApiMiddleware _apiMiddleware;

        public GroupsCRUD(IApiMethods apiMethods, ApiMiddleware apiMiddleware)
        {
            _IApiMethods = apiMethods;
            _apiMiddleware = apiMiddleware;
        }


        // Get
        // Get all groups
        public async Task<dynamic> GetAllGroupsAsync()
        {
            var response = await _apiMiddleware.ExecuteRequestAsync(() => _IApiMethods.GetGroupsAsync());
            if (!response.IsSuccess || response.Data == null)
            {
                throw new Exception(response.ErrorMessage ?? "Exception, No data in database");
            }
            return response.Data;
        }
    }
}
