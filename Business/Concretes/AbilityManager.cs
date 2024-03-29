using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Ability.Requests;
using Business.Dtos.Ability.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class AbilityManager : IAbilityService
{
    private IAbilityDal _abilityDal;
    private IMapper _mapper;

    public AbilityManager(IAbilityDal abilityDal, IMapper mapper)
    {
        _abilityDal = abilityDal;
        _mapper = mapper;
    }

    public async Task<CreatedAbilityResponse> AddAsync(CreateAbilityRequest createAbilityRequest)
    {
        var ability = _mapper.Map<Ability>(createAbilityRequest);
        var createAbility = await _abilityDal.AddAsync(ability);
        return _mapper.Map<CreatedAbilityResponse>(createAbility);
    }

    public async Task<DeletedAbilityResponse> DeleteAsync(DeleteAbilityRequest deleteAbilityRequest)
    {
        var ability = await _abilityDal.GetAsync(c => c.Id == deleteAbilityRequest.Id);
        var deleteAbility = await _abilityDal.DeleteAsync(ability);
        return _mapper.Map<DeletedAbilityResponse>(deleteAbility);
    }

    public async Task<GetAbilityResponse> GetById(GetAbilityRequest getAbilityRequest)
    {
        var getAbility = await _abilityDal.GetAsync(c => c.Id == getAbilityRequest.Id);
        return _mapper.Map<GetAbilityResponse>(getAbility);
    }

    public async Task<IPaginate<GetListedAbilityResponse>> GetListAsync(PageRequest pageRequest)
    {
        var getList = await _abilityDal.GetListAsync(include: p => p.Include(p => p.User), index: pageRequest.Index, size: pageRequest.Size);

        return _mapper.Map<Paginate<GetListedAbilityResponse>>(getList);
    }

    public async Task<UpdatedAbilityResponse> UpdateAsync(UpdateAbilityRequest updateAbilityrequest)
    {
        var ability = _mapper.Map<Ability>(updateAbilityrequest);
        var updatedAbility = await _abilityDal.UpdateAsync(ability);
        return _mapper.Map<UpdatedAbilityResponse>(updatedAbility);
    }
}