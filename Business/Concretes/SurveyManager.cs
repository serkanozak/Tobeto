using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Survey.Requests;
using Business.Dtos.Survey.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class SurveyManager : ISurveyService
{
    private ISurveyDal _surveyDal;
    private IMapper _mapper;

    public SurveyManager(ISurveyDal surveyDal, IMapper mapper)
    {
        _surveyDal = surveyDal;
        _mapper = mapper;
    }

    public async Task<CreatedSurveyResponse> AddAsync(CreateSurveyRequest createSurveyRequest)
    {
        var survey = _mapper.Map<Survey>(createSurveyRequest);
        var createSurvey = await _surveyDal.AddAsync(survey);
        return _mapper.Map<CreatedSurveyResponse>(createSurvey);
    }

    public async Task<DeletedSurveyResponse> DeleteAsync(DeleteSurveyRequest deleteSurveyRequest)
    {
        var survey = await _surveyDal.GetAsync(c => c.Id == deleteSurveyRequest.Id);
        var deleteSurvey = await _surveyDal.DeleteAsync(survey);
        return _mapper.Map<DeletedSurveyResponse>(deleteSurvey);
    }

    public async Task<GetSurveyResponse> GetById(GetSurveyRequest getSurveyRequest)
    {
        var getSurvey = await _surveyDal.GetAsync(c => c.Id == getSurveyRequest.Id);
        return _mapper.Map<GetSurveyResponse>(getSurvey);
    }

    public async Task<IPaginate<GetListedSurveyResponse>> GetListAsync(PageRequest pageRequest)
    {
        var getList = await _surveyDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
        return _mapper.Map<Paginate<GetListedSurveyResponse>>(getList);
    }

    public async Task<UpdatedSurveyResponse> UpdateAsync(UpdateSurveyRequest updateSurveyrequest)
    {
        var survey = _mapper.Map<Survey>(updateSurveyrequest);
        var updatedSurvey = await _surveyDal.UpdateAsync(survey);
        return _mapper.Map<UpdatedSurveyResponse>(updatedSurvey);
    }
}