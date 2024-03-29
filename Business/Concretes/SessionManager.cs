using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Session.Requests;
using Business.Dtos.Session.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class SessionManager : ISessionService
{
    private ISessionDal _sessionDal;
    private IMapper _mapper;

    public SessionManager(ISessionDal sessionDal, IMapper mapper)
    {
        _sessionDal = sessionDal;
        _mapper = mapper;
    }

    public async Task<CreatedSessionResponse> AddAsync(CreateSessionRequest createSessionRequest)
    {
        var session = _mapper.Map<Session>(createSessionRequest);
        var createSession = await _sessionDal.AddAsync(session);
        return _mapper.Map<CreatedSessionResponse>(createSession);
    }

    public async Task<DeletedSessionResponse> DeleteAsync(DeleteSessionRequest deleteSessionRequest)
    {
        var session = await _sessionDal.GetAsync(c => c.Id == deleteSessionRequest.Id);
        var deleteSession = await _sessionDal.DeleteAsync(session);
        return _mapper.Map<DeletedSessionResponse>(deleteSession);
    }

    public async Task<GetSessionResponse> GetById(GetSessionRequest getSessionRequest)
    {
        var getSession = await _sessionDal.GetAsync(c => c.Id == getSessionRequest.Id);
        return _mapper.Map<GetSessionResponse>(getSession);
    }

    public async Task<IPaginate<GetListedSessionResponse>> GetListAsync(PageRequest pageRequest)
    {
        var getList = await _sessionDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
        return _mapper.Map<Paginate<GetListedSessionResponse>>(getList);
    }

    public async Task<UpdatedSessionResponse> UpdateAsync(UpdateSessionRequest updateSessionrequest)
    {
        var session = _mapper.Map<Session>(updateSessionrequest);
        var updatedSession = await _sessionDal.UpdateAsync(session);
        return _mapper.Map<UpdatedSessionResponse>(updatedSession);
    }
}