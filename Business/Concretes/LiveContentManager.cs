using AutoMapper;
using Business.Abstracts;
using Business.Dtos.LiveContent.Requests;
using Business.Dtos.LiveContent.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class LiveContentManager : ILiveContentService
{
    private ILiveContentDal _liveContentDal;
    private IMapper _mapper;

    public LiveContentManager(ILiveContentDal liveContentDal, IMapper mapper)
    {
        _liveContentDal = liveContentDal;
        _mapper = mapper;
    }

    public async Task<CreatedLiveContentResponse> AddAsync(CreateLiveContentRequest createLiveContentRequest)
    {
        var liveContent = _mapper.Map<LiveContent>(createLiveContentRequest);
        var createLiveContent = await _liveContentDal.AddAsync(liveContent);
        return _mapper.Map<CreatedLiveContentResponse>(createLiveContent);
    }

    public async Task<DeletedLiveContentResponse> DeleteAsync(DeleteLiveContentRequest deleteLiveContentRequest)
    {
        var liveContent = await _liveContentDal.GetAsync(c => c.Id == deleteLiveContentRequest.Id);
        var deleteLiveContent = await _liveContentDal.DeleteAsync(liveContent);
        return _mapper.Map<DeletedLiveContentResponse>(deleteLiveContent);
    }

    public async Task<GetLiveContentResponse> GetById(GetLiveContentRequest getLiveContentRequest)
    {
        var getLiveContent = await _liveContentDal.GetAsync(c => c.Id == getLiveContentRequest.Id);
        return _mapper.Map<GetLiveContentResponse>(getLiveContent);
    }

    public async Task<IPaginate<GetListedLiveContentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var getList = await _liveContentDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
        return _mapper.Map<Paginate<GetListedLiveContentResponse>>(getList);
    }

    public async Task<UpdatedLiveContentResponse> UpdateAsync(UpdateLiveContentRequest updateLiveContentrequest)
    {
        var liveContent = _mapper.Map<LiveContent>(updateLiveContentrequest);
        var updatedLiveContent = await _liveContentDal.UpdateAsync(liveContent);
        return _mapper.Map<UpdatedLiveContentResponse>(updatedLiveContent);
    }
}