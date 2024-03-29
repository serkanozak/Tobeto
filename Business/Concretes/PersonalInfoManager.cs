using AutoMapper;
using Business.Abstracts;
using Business.Dtos.PersonalInfo.Requests;
using Business.Dtos.PersonalInfo.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class PersonalInfoManager : IPersonalInfoService
{
    private IPersonalInfoDal _personalInfoDal;
    private IMapper _mapper;

    public PersonalInfoManager(IPersonalInfoDal personalInfoDal, IMapper mapper)
    {
        _personalInfoDal = personalInfoDal;
        _mapper = mapper;
    }

    public async Task<CreatedPersonalInfoResponse> AddAsync(CreatePersonalInfoRequest createPersonalInfoRequest)
    {
        var personalInfo = _mapper.Map<PersonalInfo>(createPersonalInfoRequest);
        var createPersonalInfo = await _personalInfoDal.AddAsync(personalInfo);
        return _mapper.Map<CreatedPersonalInfoResponse>(createPersonalInfo);
    }

    public async Task<DeletedPersonalInfoResponse> DeleteAsync(DeletePersonalInfoRequest deletePersonalInfoRequest)
    {
        var personalInfo = await _personalInfoDal.GetAsync(c => c.Id == deletePersonalInfoRequest.Id);
        var deletePersonalInfo = await _personalInfoDal.DeleteAsync(personalInfo);
        return _mapper.Map<DeletedPersonalInfoResponse>(deletePersonalInfo);
    }

    public async Task<GetPersonalInfoResponse> GetById(GetPersonalInfoRequest getPersonalInfoRequest)
    {
        var getPersonalInfo = await _personalInfoDal.GetAsync(c => c.Id == getPersonalInfoRequest.Id);
        return _mapper.Map<GetPersonalInfoResponse>(getPersonalInfo);
    }

    public async Task<IPaginate<GetListedPersonalInfoResponse>> GetListAsync(PageRequest pageRequest)
    {
        var getList = await _personalInfoDal.GetListAsync(include: p => p.Include(p => p.User), index: pageRequest.Index, size: pageRequest.Size);
        return _mapper.Map<Paginate<GetListedPersonalInfoResponse>>(getList);
    }

    public async Task<UpdatedPersonalInfoResponse> UpdateAsync(UpdatePersonalInfoRequest updatePersonalInforequest)
    {
        var personalInfo = _mapper.Map<PersonalInfo>(updatePersonalInforequest);
        var updatedPersonalInfo = await _personalInfoDal.UpdateAsync(personalInfo);
        return _mapper.Map<UpdatedPersonalInfoResponse>(updatedPersonalInfo);
    }
}