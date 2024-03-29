using Business.Dtos.Survey.Requests;
using Business.Dtos.Survey.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ISurveyService
{
    Task<IPaginate<GetListedSurveyResponse>> GetListAsync(PageRequest pageRequest);
    Task<CreatedSurveyResponse> AddAsync(CreateSurveyRequest createSurveyRequest);
    Task<UpdatedSurveyResponse> UpdateAsync(UpdateSurveyRequest updateSurveyrequest);
    Task<DeletedSurveyResponse> DeleteAsync(DeleteSurveyRequest deleteSurveyRequest);
    Task<GetSurveyResponse> GetById(GetSurveyRequest getSurveyRequest);
}