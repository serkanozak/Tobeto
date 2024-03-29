using AutoMapper;
using Business.Abstracts;
using Business.Dtos.PasswordReset.Requests;
using Business.Dtos.PasswordReset.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class PasswordResetManager : IPasswordResetService
{
    private IPasswordResetDal _passwordResetDal;
    private IMapper _mapper;

    public PasswordResetManager(IPasswordResetDal passwordResetDal, IMapper mapper)
    {
        _passwordResetDal = passwordResetDal;
        _mapper = mapper;
    }

    public async Task<CreatedPasswordResetResponse> AddAsync(CreatePasswordResetRequest createPasswordResetRequest)
    {
        var passwordReset = _mapper.Map<PasswordReset>(createPasswordResetRequest);
        var createPasswordReset = await _passwordResetDal.AddAsync(passwordReset);
        return _mapper.Map<CreatedPasswordResetResponse>(createPasswordReset);
    }

    public async Task<DeletedPasswordResetResponse> DeleteAsync(DeletePasswordResetRequest deletePasswordResetRequest)
    {
        var passwordReset = await _passwordResetDal.GetAsync(c => c.Id == deletePasswordResetRequest.Id);
        var deletePasswordReset = await _passwordResetDal.DeleteAsync(passwordReset);
        return _mapper.Map<DeletedPasswordResetResponse>(deletePasswordReset);
    }

    public async Task<GetPasswordResetResponse> GetById(GetPasswordResetRequest getPasswordResetRequest)
    {
        var getPasswordReset = await _passwordResetDal.GetAsync(c => c.Id == getPasswordResetRequest.Id);
        return _mapper.Map<GetPasswordResetResponse>(getPasswordReset);
    }

    public async Task<IPaginate<GetListedPasswordResetResponse>> GetListAsync(PageRequest pageRequest)
    {
        var getList = await _passwordResetDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
        return _mapper.Map<Paginate<GetListedPasswordResetResponse>>(getList);
    }

    public async Task<UpdatedPasswordResetResponse> UpdateAsync(UpdatePasswordResetRequest updatePasswordResetrequest)
    {
        var passwordReset = _mapper.Map<PasswordReset>(updatePasswordResetrequest);
        var updatedPasswordReset = await _passwordResetDal.UpdateAsync(passwordReset);
        return _mapper.Map<UpdatedPasswordResetResponse>(updatedPasswordReset);
    }
}